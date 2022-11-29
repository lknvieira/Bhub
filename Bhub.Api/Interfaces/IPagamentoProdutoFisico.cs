using Bhub.Api.Models;

namespace Bhub.Api.Interfaces
{
    public interface IPagamentoProdutoFisico : IPagamento
    {
        Task<List<GuiaRemessa>> GerarGuiaDeRemessa();

        Task<Comissao> GerarComissão();
    }
}