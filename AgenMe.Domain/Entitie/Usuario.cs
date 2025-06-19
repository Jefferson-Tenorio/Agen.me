namespace AgenMe.Domain.Entitie.AgenMe.Domain.Entities
{
    public class Usuario
    {
        public class Usuario
        {
            public int Id { get; private set; }
            public string Nome { get; private set; }
            public string Email { get; private set; }
            public string Telefone { get; private set; }

            public bool Ativo { get; private set; }

            public DateTime DataCriacao { get; private set; }
            public DateTime? DataAtualizacao { get; private set; }

            // 🔗 Relacionamento opcional (Agendamentos feitos pelo usuário)
            public IReadOnlyCollection<Agendamento> Agendamentos => _agendamentos.AsReadOnly();
            private List<Agendamento> _agendamentos = new();

            // 🔧 Construtor protegido para ORM
            protected Usuario() { }

            // 🔥 Construtor principal
            public Usuario(string nome, string email, string telefone)
            {
                ValidarDados(nome, email, telefone);

                Nome = nome;
                Email = email;
                Telefone = telefone;
                Ativo = true;
                DataCriacao = DateTime.Now;
            }

            // 🎯 Métodos de comportamento

            public void Atualizar(string nome, string email, string telefone)
            {
                ValidarDados(nome, email, telefone);

                Nome = nome;
                Email = email;
                Telefone = telefone;
                AtualizarData();
            }

            public void Ativar()
            {
                Ativo = true;
                AtualizarData();
            }

            public void Desativar()
            {
                Ativo = false;
                AtualizarData();
            }

            public void AdicionarAgendamento(Agendamento agendamento)
            {
                if (agendamento == null)
                    throw new ArgumentException("Agendamento inválido.");

                _agendamentos.Add(agendamento);
                AtualizarData();
            }

            // 🔒 Validação interna dos dados
            private void ValidarDados(string nome, string email, string telefone)
            {
                if (string.IsNullOrWhiteSpace(nome))
                    throw new ArgumentException("O nome é obrigatório.");

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                    throw new ArgumentException("E-mail inválido.");

                if (string.IsNullOrWhiteSpace(telefone))
                    throw new ArgumentException("O telefone é obrigatório.");
            }

            private void AtualizarData()
            {
                DataAtualizacao = DateTime.Now;
            }
        }
    }
}