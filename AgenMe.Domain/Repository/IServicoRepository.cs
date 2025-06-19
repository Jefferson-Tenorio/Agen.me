using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Domain.Entitie.AgenMe.Domain.Entities;

namespace AgenMe.Domain.Repository
{
    public interface IServicoRepository
    {
        public interface IServicoRepository
        {
            // 🔍 Consultas
            Task<Servico?> ObterPorIdAsync(int id);
            Task<IEnumerable<Servico>> ObterTodosAsync();
            Task<IEnumerable<Servico>> ObterAtivosAsync();

            // ✅ Persistência
            Task AdicionarAsync(Servico servico);
            Task AtualizarAsync(Servico servico);
            Task RemoverAsync(Servico servico);

            // 🔎 Validação
            Task<bool> ExisteAsync(int id);
        }
    }
}
