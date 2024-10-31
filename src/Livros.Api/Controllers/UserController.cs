using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Livros.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserAppService _userAppService;

    public UserController(IUserAppService userAppService)
       => _userAppService = userAppService;

    [HttpGet]
    [Route("ListarUsuarios")]
    public IActionResult Get()
    {
        var user = _userAppService.ListarUsers();
        if (user != null && user.Any())
            return StatusCode(200, new { message = "Usuário(s) encontrado(s)", quantidade = user.Count(), user });

        return BadRequest(new { message = "Nenhum usuário encontrado." });
    }

    [HttpPost]
    [Route("CriarUsuario")]
    public IActionResult Post([FromBody] CriarUserDto dto)
    {
        try
        {
            _userAppService.CriarUser(dto);
            return StatusCode(201, new { message = "Usuário criado com sucesso." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro ao criar usuário.", erro = ex.Message });
        }
    }
}