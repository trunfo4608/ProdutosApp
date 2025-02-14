using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Services
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoRepository? _produtoRepository;

        public ProdutoDomainService(IProdutoRepository? produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public void Adicionar(Produto produto)
        {
            produto.DataCriacao = DateTime.Now;
            produto.DataUltimaAlteracao = DateTime.Now;
            produto.Ativo = 1;

            _produtoRepository?.Add(produto);
        }

        public void Alterar(Produto produto)
        {
            var registro = _produtoRepository?.GetById(produto.Id);

            if(registro != null)
            {
                registro.Nome = produto.Nome;
                registro.Descricao = produto.Descricao;
                registro.Preco = produto.Preco;
                registro.Qtde = produto.Qtde;
                registro.DataUltimaAlteracao = DateTime.Now;

                _produtoRepository?.Update(registro);
            }
            else
            {
                throw new Exception("Produto nao encontrado, verifique o id.");
            }
        }

        public void Excluir(int id)
        {
            var registro = _produtoRepository?.GetById(id);

            if(registro != null)
            {
                _produtoRepository?.Delete(registro);
            }
            else
            {
                throw new Exception("Produto nao encontrado, verifique o id.");
            }
        }

        public Produto? ObterPorId(int id)
        {
            return _produtoRepository?.GetById(id);
        }

        public List<Produto> ObterTodos()
        {
            return _produtoRepository?.GetAll();
        }
    }
}
