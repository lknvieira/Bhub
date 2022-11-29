using Bhub.Api.Models;

namespace Bhub.Api.ViewModels
{
    public class AssociacaoViewModel : PagamentoViewModel
    {
        public Associacao Associacao { get; set; }
        public Email Email { get; set; }
    }
}
