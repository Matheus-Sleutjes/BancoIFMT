using Banco.Data.Content;
using Banco.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banco.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IUserRepository _userRepository ;

    [HttpPost("Create")]
    public IActionResult Create([FromBody] LoginModel request )
    {
        _userRepository.Create(request);
        return Ok(request);
    }
}
