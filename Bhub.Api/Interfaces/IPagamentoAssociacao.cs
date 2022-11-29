using Bhub.Api.Models;

namespace Bhub.Api.Interfaces
{
    public interface IPagamentoAssociacao : IPagamento
    {
        Task<Email> EnviarEmail(Associacao associacao);
        Task<Associacao> Ativa();
        Task<Associacao> Upgrade();
    }
}
