using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Domain.Enums;
using Microsoft.VisualBasic;

namespace AgenMe.Domain.Entitie
{
    namespace AgenMe.Domain.Entities
    {
        public class Agendamento
        {
            public int Id { get; private set; }
            public DateTime DataHora { get; private set; }
            public int UsuarioId { get; private set; }
            public int ServicoId { get; private set; }
            public StatusAgendamento Status { get; private set; }
            public string? Observacoes { get; private set; }

            public DateTime DataCriacao { get; private set; }
            public DateTime? DataAtualizacao { get; private set; }

            // 🔧 Construtor protegido para o EF ou ORM
            protected Agendamento() { }

            // 🔥 Construtor principal
            public Agendamento(DateTime dataHora, int usuarioId, int servicoId, string? observacoes = null)
            {
                if (dataHora <= DateTime.Now)
                    throw new ArgumentException("A data do agendamento deve ser futura.");

                DataHora = dataHora;
                UsuarioId = usuarioId;
                ServicoId = servicoId;
                Observacoes = observacoes;
                Status = StatusAgendamento.Pendente;
                DataCriacao = DateTime.Now;
            }

            // 🎯 Métodos de comportamento (Regra de negócio)

            public void Confirmar()
            {
                if (Status != StatusAgendamento.Pendente)
                    throw new InvalidOperationException("Apenas agendamentos pendentes podem ser confirmados.");

                Status = StatusAgendamento.Confirmado;
                AtualizarData();
            }

            public void Cancelar()
            {
                if (Status == StatusAgendamento.Finalizado)
                    throw new InvalidOperationException("Não é possível cancelar um agendamento finalizado.");

                Status = StatusAgendamento.Cancelado;
                AtualizarData();
            }

            public void Finalizar()
            {
                if (Status != StatusAgendamento.Confirmado)
                    throw new InvalidOperationException("Somente agendamentos confirmados podem ser finalizados.");

                Status = StatusAgendamento.Finalizado;
                AtualizarData();
            }

            public void Reagendar(DateTime novaDataHora)
            {
                if (novaDataHora <= DateTime.Now)
                    throw new ArgumentException("A nova data deve ser futura.");

                if (Status == StatusAgendamento.Cancelado)
                    throw new InvalidOperationException("Não é possível reagendar um agendamento cancelado.");

                DataHora = novaDataHora;
                AtualizarData();
            }

            private void AtualizarData()
            {
                DataAtualizacao = DateTime.Now;
            }
        }
    }
}
