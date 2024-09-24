namespace AutoPecas.Models
{
    public class PecaFabricante
    {

        public Fabricante fabricante { get; set; }
        public Peca peca { get; set; }
        public float valor_compra { get; set; }
        public int qtd { get; set; }
    }
}
