using Bhub.Api.Interfaces;
using Bhub.Api.Models;

namespace Bhub.Services
{
    public class PagamentoService : IPagamento
    {
        public async Task<Pagamento> GerarPagamento()
        {
            return await Task.FromResult(new Pagamento(10, DateTime.Now));
        }
    }
}
