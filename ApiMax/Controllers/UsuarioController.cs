using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMax.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiMax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type= typeof(LoginViewModelInput))]
        //[SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelInput)]
        //[SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel)]


        [HttpPost]
        [Route("Logar")]
        public IActionResult Logar(LoginViewModelInput LoginViewModelInput)
        {
            return Ok(LoginViewModelInput);
        } 
        
        [HttpPost]
        [Route("Registrar")]
        public IActionResult Registrar(RegistroViewModelInput RegistroViewModelInput)
        {
            return Created("", RegistroViewModelInput);
        }
    }
}