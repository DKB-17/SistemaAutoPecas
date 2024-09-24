using System.ComponentModel.DataAnnotations.Schema;

namespace AutoPecas.Models
{

    [Table("Fabricantes")]
    public class Fabricante
    {
        public int id { get; set; }
        public string descricao { get; set; }

    }
}
