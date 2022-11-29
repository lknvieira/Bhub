using Bhub.Api.Models;

namespace Bhub.Api.Interfaces
{
    public interface IPagamento
    {
        Task<Pagamento> GerarPagamento();
    }
}
