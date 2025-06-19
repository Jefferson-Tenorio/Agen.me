namespace AgenMe.Domain.Entitie.AgenMe.Domain.Entities
{
    public class Servico
    {
        public class Servico
        {
            public int Id { get; private set; }
            public string Nome { get; private set; }
            public string? Descricao { get; private set; }
            public decimal Preco { get; private set; }
            public TimeSpan Duracao { get; private set; } // Ex.: 01:30 → 1h30min
            public bool Ativo { get; private set; }

            public DateTime DataCriacao { get; private set; }
            public DateTime? DataAtualizacao { get; private set; }

            // 🔧 Construtor protegido para o EF
            protected Servico() { }

            // 🔥 Construtor principal
            public Servico(string nome, string? descricao, decimal preco, TimeSpan duracao)
            {
                ValidarDados(nome, preco, duracao);

                Nome = nome;
                Descricao = descricao;
                Preco = preco;
                Duracao = duracao;
                Ativo = true;
                DataCriacao = DateTime.Now;
            }

            // 🎯 Métodos de comportamento

            public void Atualizar(string nome, string? descricao, decimal preco, TimeSpan duracao)
            {
                ValidarDados(nome, preco, duracao);

                Nome = nome;
                Descricao = descricao;
                Preco = preco;
                Duracao = duracao;
                AtualizarData();
            }

            public void Desativar()
            {
                Ativo = false;
                AtualizarData();
            }

            public void Ativar()
            {
                Ativo = true;
                AtualizarData();
            }

            // 🔒 Métodos auxiliares

            private void ValidarDados(string nome, decimal preco, TimeSpan duracao)
            {
                if (string.IsNullOrWhiteSpace(nome))
                    throw new ArgumentException("O nome do serviço é obrigatório.");

                if (preco < 0)
                    throw new ArgumentException("O preço não pode ser negativo.");

                if (duracao.TotalMinutes <= 0)
                    throw new ArgumentException("A duração deve ser maior que zero.");
            }

            private void AtualizarData()
            {
                DataAtualizacao = DateTime.Now;
            }
        }
    }
}