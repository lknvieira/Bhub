using Bhub.Api.Interfaces;
using Bhub.Api.Models;

namespace Bhub.Services
{
    public class PagamentoLivro : PagamentoService, IPagamentoLivro
    {
        public async Task<Comissao> GerarComissão()
        {
            return await Task.FromResult(new Comissao());
        }

        public Task<List<GuiaRemessa>> GerarGuiaDeRemessa()
        {
            var guiaRemessa = new GuiaRemessa("Gerando uma guia de remessa duplicada", new Produto("Livro"));

            return Task.FromResult(new List<GuiaRemessa> { guiaRemessa, guiaRemessa });
        }
    }
}
