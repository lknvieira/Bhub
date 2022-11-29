namespace Bhub.Api.Models
{
    public class Pagamento
    {
        public Pagamento(decimal valor, DateTime data)
        {
            Valor = valor;
            Data = data;
        }

        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
