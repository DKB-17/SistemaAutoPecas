using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoPecas.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }
        [Required(ErrorMessage = "Campo descricao é obrigatorio...")]
        [StringLength(150, ErrorMessage = "Tamanho maximo de 150 caracteres")]
        [Display(Name = "Descricao: ")]
        public string descricao { get; set; }


    }
}
