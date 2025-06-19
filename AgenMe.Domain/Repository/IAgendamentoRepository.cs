using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Domain.Entitie.AgenMe.Domain.Entities;

namespace AgenMe.Domain.Repository
{
    public interface IAgendamentoRepository
    {
        // 🔍 Consulta
        Task<Agendamento?> ObterPorIdAsync(int id);
        Task<IEnumerable<Agendamento>> ObterPorUsuarioAsync(int usuarioId);
        Task<IEnumerable<Agendamento>> ObterPorServicoAsync(int servicoId);
        Task<IEnumerable<Agendamento>> ObterPorDataAsync(DateTime data);
        Task<IEnumerable<Agendamento>> ObterTodosAsync();

        // ✅ Persistência
        Task AdicionarAsync(Agendamento agendamento);
        Task AtualizarAsync(Agendamento agendamento);
        Task RemoverAsync(Agendamento agendamento);

        // 🔎 Validações específicas (opcional, mas recomendável)
        Task<bool> ExisteConflitoDeHorarioAsync(int servicoId, DateTime dataHora);
        Task<bool> ExisteAsync(int id);
    }
}
