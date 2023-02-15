using Banco.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banco.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("Create")]
    public IActionResult Create([FromBody] LoginModel request )
    {
        if(request.Username == "admin" && request.Password == "admin")
            return Ok("Logado");

        return BadRequest("Não autorizado");    
    }
}
