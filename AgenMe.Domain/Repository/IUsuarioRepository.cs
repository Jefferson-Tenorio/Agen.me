using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Domain.Entitie.AgenMe.Domain.Entities;

namespace AgenMe.Domain.Repository
{
    public interface IUsuarioRepository
    {
        // 🔍 Consultas
        Task<Usuario?> ObterPorIdAsync(int id);
        Task<Usuario?> ObterPorEmailAsync(string email);
        Task<IEnumerable<Usuario>> ObterTodosAsync();
        Task<IEnumerable<Usuario>> ObterAtivosAsync(); 

        // ✅ Persistência
        Task AdicionarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task RemoverAsync(Usuario usuario);

        // 🔎 Validação
        Task<bool> ExisteAsync(int id);
        Task<bool> ExistePorEmailAsync(string email);
    }
}
