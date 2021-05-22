using Microsoft.AspNetCore.Mvc;
using TesteUnidas.Services.Interfaces;

namespace TesteUnidas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class SenhaController : ControllerBase
    {
        private readonly ISenhaService senhaService;

        public SenhaController(ISenhaService senhaService)
        {
            this.senhaService = senhaService;
        }

        [HttpPost]
        public IActionResult ValidarSenha([FromBody] string senha)
        {
            return Ok(senhaService.ValidarSenha(senha));
        }

    }
}
