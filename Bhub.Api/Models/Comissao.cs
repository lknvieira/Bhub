namespace Bhub.Api.Models
{
    public class Comissao
    {
        public Comissao()
        {
            Id = Guid.NewGuid();
            Descricao = "Gerando pagamento de comissão ao agente";
        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
    }
}
