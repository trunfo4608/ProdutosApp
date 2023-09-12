using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        /// <summary>
        /// Método para cadastrar produtos na API
        /// </summary>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        /// <summary>
        /// Método para atualizar produtos na API
        /// </summary>
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        /// <summary>
        /// Método para excluir produtos na API
        /// </summary>
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Método para consultar produtos na API
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
