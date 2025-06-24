using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fiap_arquitetura_jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [Authorize(Policy = "Admin")]
        [HttpGet("admin")]
        public IActionResult GetAdminOnly()
        {
            return Ok("Acesso permitido para ADMIN");
        }

        [Authorize(Policy = "Usuario")]
        [HttpGet("usuario")]
        public IActionResult GetUsuarioOnly()
        {
            return Ok("Acesso permitido para USUÁRIO");

        }         

    }
}
