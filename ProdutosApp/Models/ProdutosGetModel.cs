namespace ProdutosApp.Models
{
    public class ProdutosGetModel
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Qtde { get; set; }
        public decimal? Total { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }


    }
}
