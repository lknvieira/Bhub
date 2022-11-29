namespace Bhub.Api.Models
{
    public class Produto
    {
        public string Nome { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}
