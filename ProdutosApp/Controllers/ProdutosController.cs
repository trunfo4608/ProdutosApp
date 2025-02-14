using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interface;
using ProdutosApp.Models;

namespace ProdutosApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoDomainService? _produtoDomainsService;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoDomainService? produtoDomainsService, IMapper? mapper)
        {
            _produtoDomainsService = produtoDomainsService;
            _mapper = mapper;
        }

        /// <summary>
        /// cadastrar o produto
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProdutosGetModel), 201)]
        public IActionResult Post([FromBody] ProdutosPostModel model)
        {
            try
            {
                var produto = _mapper?.Map<Produto>(model);
                _produtoDomainsService?.Adicionar(produto);

                var response = _mapper?.Map<ProdutosGetModel>(produto);
                return StatusCode(201, response);
            }
            catch (ApplicationException e)
            {

                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }

        }

  
        /// <summary>
        /// atualizar o produto
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(ProdutosGetModel),200)]
        public IActionResult Put([FromBody] ProdutosPutModel model)
        {
            try
            {
                var produto = _mapper?.Map<Produto>(model);
                _produtoDomainsService?.Alterar(produto);

                var response = _mapper?.Map<ProdutosGetModel>(produto);

                return StatusCode(200, response);
            }
            catch (ApplicationException e)
            {

                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }


        /// <summary>
        /// deletar o produto
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProdutosGetModel),200)]
        public IActionResult Delete(int id)
        {
            try
            {
                var produto = _produtoDomainsService?.ObterPorId(id);
                _produtoDomainsService?.Excluir(id);

                var response = _mapper?.Map<ProdutosGetModel>(produto);
                return StatusCode(200, response);

            }

            catch (ApplicationException e)
            {

                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// buscar todos os produto
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutosGetModel>),200)]
        public IActionResult GetAll()
        {
            try
            {
                var produtos = _produtoDomainsService?.ObterTodos();

                var response = _mapper?.Map<List<ProdutosGetModel>>(produtos);
                return StatusCode(200, response);

            }
            catch (ApplicationException e)
            {
                return StatusCode(400, new { e.Message });

            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
                
            }
        }

        /// <summary>
        /// buscar um produto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<ProdutosGetModel>), 200)]
        public IActionResult GetById(int id)
        {
            try
            {
                var produto = _produtoDomainsService?.ObterPorId(id);

                if(produto == null)
                {
                    return NoContent();
                }

                var response = _mapper?.Map<ProdutosGetModel>(produto);
                return StatusCode(200, response);

            }
            catch (ApplicationException e)
            {
                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {

                return StatusCode(500, new { e.Message });
            }
        }
    }
}
