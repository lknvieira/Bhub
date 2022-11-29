namespace Bhub.Api.Models
{
    public class Associacao
    {
        public Associacao(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }
    }
}
