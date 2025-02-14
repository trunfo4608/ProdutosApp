using System.ComponentModel.DataAnnotations;

namespace ProdutosApp.Models
{
    public class ProdutosPostModel
    {
        [StringLength(50,MinimumLength =5,ErrorMessage ="Nome tem que ter entre {2} e {1} caracteres")]
        [Required(ErrorMessage ="Nome do produto obrigatorio")]
        public string? Nome { get;set; }


        [StringLength(100, MinimumLength = 10, ErrorMessage = "Descricao tem que ter entre {2} e {1} caracteres.")]
        [Required(ErrorMessage = "Descricao do produto obrigatorio.")]
        public string? descricao { get;set; }

        [Range(0,99999,ErrorMessage ="Preco valor entre {1} e {2}.")]
        [Required(ErrorMessage ="Preco do produto obrigatorio.")]
        public decimal? Preco { get; set; }

        [Range(0,9999,ErrorMessage ="Quantidade entre {1} e {2}.")]
        [Required(ErrorMessage ="Quantidade do produto obrigatorio.")]
        public int? Qtde { get; set; }
    }
}
