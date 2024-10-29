using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Livros.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorAppService _authorAppService;

    public AuthorController(IAuthorAppService authorAppService)
      =>  _authorAppService = authorAppService;

    [HttpGet]
    [Route("ListarAutores")]
    public IActionResult GetAll()
    {
        var autores = _authorAppService.ListarAutores();
        if(autores != null && autores.Any())
            return StatusCode(200, new { message = "Autore(s) encontrado(s)", quantidade = autores.Count(), autores});

        return BadRequest(new { message = "Nenhum Author encontrado." });
    }

    [HttpPost]
    [Route("CriarAutor")]
    public IActionResult Post([FromBody] CriarAuthorDto author)
    {
        try
        {
            _authorAppService.CriarAutor(author);
            return StatusCode(201, new { message = "Autor criado com sucesso." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro ao criar autor.", erro = ex.Message });
        }
    }
}