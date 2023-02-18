using Banco.Data.Content;
using Banco.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banco.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IUserRepository _userRepository ;
    public AuthenticationController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost("Create")]
    public IActionResult Create([FromBody] LoginModel request )
    {
        _userRepository.Create(request);
        return Ok(request);
    }

    [HttpPost("Login")]
    public IActionResult Login([FromBody] LoginModel request)
    {
        var model = _userRepository.Get(request);
        if (model.Password == request.Password)
            return Ok("Autorizado!");
        return BadRequest("N�o Autorizado!");
    }
}
