using System.ComponentModel.DataAnnotations;

namespace AutoPecas.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public Veiculo veiculo { get; set; }
        public Responsavel responsavel { get; set; }
        public string descricao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime data_servico { get; set; }
        public float mao_obra { get; set; }
        public float valor_total { get; set; }
    }
}
