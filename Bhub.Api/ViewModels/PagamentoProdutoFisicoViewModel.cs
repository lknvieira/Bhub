using Bhub.Api.Models;

namespace Bhub.Api.ViewModels
{
    public class PagamentoProdutoFisicoViewModel : PagamentoViewModel
    {
        public List<GuiaRemessa> GuiaRemessas { get; set; }
        public Comissao Comissao { get; set; }
    }
}
