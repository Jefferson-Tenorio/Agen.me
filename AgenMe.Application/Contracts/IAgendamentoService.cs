using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Application.DTOs;

namespace AgenMe.Application.Contracts
{
    public interface IAgendamentoService
    {
        Task<AgendamentoDto> CriarAsync(AgendamentoDto dto);
        Task<AgendamentoDto> ObterPorIdAsync(int id);
        Task<IEnumerable<AgendamentoDto>> ObterPorUsuarioAsync(int usuarioId);
        Task<IEnumerable<AgendamentoDto>> ObterPorServicoAsync(int servicoId);
        Task<IEnumerable<AgendamentoDto>> ObterTodosAsync();

        Task ConfirmarAsync(int id);
        Task CancelarAsync(int id);
        Task FinalizarAsync(int id);
        Task ReagendarAsync(int id, DateTime novaDataHora);
        Task RemoverAsync(int id);
    }
}
