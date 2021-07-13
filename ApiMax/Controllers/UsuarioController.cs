using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMax.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
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