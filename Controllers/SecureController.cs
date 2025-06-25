using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fiap_arquitetura_jwt.Controllers;


[Route("api/[controller]")]
[ApiController]
public class SecureController : ControllerBase
{
    [HttpGet("admin")]
    [Authorize(Roles = "Admin")]
    public IActionResult AdminOnly()
    {
        return Ok("Acesso permitido para ADMIN");
    }

  
    [HttpGet("user")]
    [Authorize]
    public IActionResult AnyUser()
    {
        return Ok("Acesso permitido para USUÁRIO");

    }         

}
