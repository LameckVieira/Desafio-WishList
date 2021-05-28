using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using WishList_SENAI.Interfaces;
using WishList_SENAI.Repositories;
using WishList_SENAI.Domains;

namespace WishList_SENAI.Controllers
{    
    //define que o tipo de reposta da API será no formato JSON
    [Produces("application/json")]
    //define que a rota de uma requisição será no formato domínio/api/NomeController
    //ex: http://localhost:5000/api/desejos
    [Route("api/[controller]")]
    //Define que é um controlador de API
    [ApiController]
    public class desejosController : ControllerBase
    {
        private IDesejoRepository _desejoRepository { get; set; }


        public desejosController()
        {
            _desejoRepository = new desejoRepository();
        }

        /// <summary>
        /// Lista todos os desejos
        /// </summary>
        /// <returns>Uma lista de desejos e um status code 200 - ok </returns>
        [HttpGet]
        public IActionResult Get()
        {
            //retorna a resposta da  requisição fazendo uma chamada para o método
            return Ok(_desejoRepository.ListarTodos());
        }

        /// <summary>
        /// Cadastra um novo desejo
        /// </summary>
        /// <param name="novoDesejo">objeto novoDesejo que será cadastrado</param>
        /// <returns>um statud code 201- Created</returns>
        [HttpPost]
        public IActionResult Post(Desejo novoDesejo)

        {
            //faza a chamada para o método 
            _desejoRepository.Cadastrar(novoDesejo);

            return StatusCode(201);
        }

    }
}
