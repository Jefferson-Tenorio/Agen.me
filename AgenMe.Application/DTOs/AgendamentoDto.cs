using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenMe.Application.DTOs
{
    public class AgendamentoDto
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int UsuarioId { get; set; }
        public int ServicoId { get; set; }
        public string? Observacoes { get; set; }
        public string Status { get; set; } = string.Empty;

        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
