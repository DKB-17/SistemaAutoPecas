using System.ComponentModel.DataAnnotations;

namespace AutoPecas.Models
{
    public class Fornecedor
    {
        public int id { get; set; }
        public Cidade cidade { get; set; }
        public string nome { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{5})[-. ]?([0-9]{4})$",ErrorMessage = "Este formato de telefone não é valido")]
        public string telefone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
    }
}
