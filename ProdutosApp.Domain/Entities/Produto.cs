using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get;set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Qtde { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public int? Ativo { get; set; }
    }
}
