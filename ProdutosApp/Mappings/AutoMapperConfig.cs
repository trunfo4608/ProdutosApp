using AutoMapper;
using ProdutosApp.Domain.Entities;
using ProdutosApp.Models;

namespace ProdutosApp.Mappings
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig()
        {
            CreateMap<ProdutosPostModel,Produto>();
            CreateMap<ProdutosPutModel, Produto>();

            CreateMap<Produto, ProdutosGetModel>()
              .AfterMap((entity, model) =>
            {
                model.Total = entity.Qtde * entity.Preco;
            });



        }


    }
}
