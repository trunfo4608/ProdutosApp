using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutosApp.Data.Context;

namespace ProdutosApp.Data.Repositories
{
    public class ProdutoRepositories : IProdutoRepository
    {
        public void Add(Produto produto)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Add(produto);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Produto produto)
        {
            produto.Ativo = 0;
            Update(produto);
        }

        public List<Produto> GetAll()
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Produtos
                       .Where(p => p.Ativo == 1)
                       .OrderBy(p => p.Nome)
                       .ToList();
                    
            }
        }

        public Produto? GetById(int id)
        {
            using(var dataConetxt = new DataContext())
            {
                return dataConetxt.Produtos
                       .Where(p => p.Id == id && p.Ativo == 1)
                       .FirstOrDefault();
            }
        }

        public void Update(Produto produto)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Update(produto);
                dataContext.SaveChanges();
            }
        }
    }
}
