namespace Bhub.Api.Models
{
    public class GuiaRemessa
    {
        public GuiaRemessa(string descricao, Produto produto)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Produto.Add(produto);
        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produto { get; set; } = new List<Produto>();

        public void AddProduto(Produto produto)
        {
            Produto.Add(produto);
        }
    }
}
