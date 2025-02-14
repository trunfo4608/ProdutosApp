using ProdutosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Interface
{
    public interface IProdutoDomainService
    {
        void Adicionar(Produto produto);
        void Alterar(Produto produto);
        void Excluir(int id);
        List<Produto> ObterTodos();
        Produto? ObterPorId(int id);

    }
}
