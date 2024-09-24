namespace AutoPecas.Models
{
    public class ServicoPeca
    {
        public Servico servico { get; set; }
        public Peca peca { get; set; }
        public int qtd { get; set; }
        public float valor_venda { get; set; }
    }
}
