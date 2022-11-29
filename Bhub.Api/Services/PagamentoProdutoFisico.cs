using Bhub.Api.Interfaces;
using Bhub.Api.Models;

namespace Bhub.Services
{
    public class PagamentoProdutoFisico : PagamentoService, IPagamentoProdutoFisico
    {
        public async Task<Comissao> GerarComissão()
        {
            return await Task.FromResult(new Comissao());
        }

        public virtual async Task<List<GuiaRemessa>> GerarGuiaDeRemessa()
        {
            return await Task.FromResult(new List<GuiaRemessa> 
            { 
                new GuiaRemessa("Gerando uma guia de remessa", new Produto("Produto Físico")) 
            });
        }
    }
}
