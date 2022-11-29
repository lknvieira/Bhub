using Bhub.Api.Interfaces;
using Bhub.Api.Models;

namespace Bhub.Services
{
    public class PagamentoVideoAprendendoEsquiar : PagamentoProdutoFisico, IPagamentoVideoAprendendoEsquiar
    {

        public override async Task<List<GuiaRemessa>> GerarGuiaDeRemessa()
        {
            var remessaAprendendoEsquiar = new GuiaRemessa("Gerando uma guia de remessa", new Produto("Video Aprendendo Esquiar"));

            remessaAprendendoEsquiar.AddProduto(new Produto("Vídeo gratuíto de Primeiros Socorros"));

            return await Task.FromResult(new List<GuiaRemessa>() { remessaAprendendoEsquiar });
        }
    }
}
