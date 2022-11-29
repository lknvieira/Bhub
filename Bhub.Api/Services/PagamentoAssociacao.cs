using Bhub.Api.Interfaces;
using Bhub.Api.Models;

namespace Bhub.Services
{
    public class PagamentoAssociacao : PagamentoService, IPagamentoAssociacao
    {
        public Task<Associacao> Ativa()
        {
            return Task.FromResult(new Associacao("Nova Associação - Level 1"));
        }

        public Task<Email> EnviarEmail(Associacao associacao)
        {
            return Task.FromResult(new Email("cliente@cliente.com", "bhub@bhub.com", associacao.Descricao));
        }

        public Task<Associacao> Upgrade()
        {
            return Task.FromResult(new Associacao("Upgrade Associação - Level 2"));
        }
    }
}
