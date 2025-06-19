using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Application.DTOs;

namespace AgenMe.Application.Contracts
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> CriarAsync(UsuarioDto dto);
        Task<UsuarioDto> ObterPorIdAsync(int id);
        Task<UsuarioDto> ObterPorEmailAsync(string email);
        Task<IEnumerable<UsuarioDto>> ObterTodosAsync();
        Task<IEnumerable<UsuarioDto>> ObterAtivosAsync();

        Task AtualizarAsync(UsuarioDto dto);
        Task AtivarAsync(int id);
        Task DesativarAsync(int id);
        Task RemoverAsync(int id);
    }
}
