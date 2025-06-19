using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Application.DTOs;

namespace AgenMe.Application.Contracts
{
    public interface IServicoService
    {
        Task<ServicoDto> CriarAsync(ServicoDto dto);
        Task<ServicoDto> ObterPorIdAsync(int id);
        Task<IEnumerable<ServicoDto>> ObterTodosAsync();
        Task<IEnumerable<ServicoDto>> ObterAtivosAsync();

        Task AtualizarAsync(ServicoDto dto);
        Task AtivarAsync(int id);
        Task DesativarAsync(int id);
        Task RemoverAsync(int id);
    }
}
