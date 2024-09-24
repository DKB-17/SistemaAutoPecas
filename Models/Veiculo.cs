namespace AutoPecas.Models
{
    public class Veiculo
    {
        public int id { get; set; }
        public string placa { get; set; }
        public Ano ano { get; set; }
        public Modelo modelo { get; set; }
        public Cliente cliente { get; set; }

    }
}
