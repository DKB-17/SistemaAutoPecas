using System.ComponentModel.DataAnnotations;

namespace AutoPecas.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Cidade cidade { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{5})[-. ]?([0-9]{4})$", ErrorMessage = "Este formato de telefone não é valido")]
        public string telefone { get; set; }
        [RegularExpression(@"^?([0-9]{3})\.?([0-9]{3})\.?[-. ]?([0-9]{2})$", ErrorMessage = "Este formato de cpf não é valido")]
        public string cpf { get; set; }
        public string endereco { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
    }
}
