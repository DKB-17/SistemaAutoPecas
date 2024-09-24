namespace AutoPecas.Models
{
    public class Peca
    {

        public int id { get; set; }
        public PecaFabricante PecaDeFabricante { get; set; }
        public Categoria categoria { get; set; }
        public string descricao { get; set; }
        public float valor_total { get; set; }
        public int qtd_estoque { get; set; }

    }
}
