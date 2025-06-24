using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fiap_arquitetura_jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IConfiguration configuration) : ControllerBase
    {
    }
}
