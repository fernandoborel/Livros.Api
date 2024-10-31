using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Livros.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livros.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookAppService _bookAppService;

    public BookController(IBookAppService bookAppService)    
       => _bookAppService = bookAppService;

    [HttpGet]
    [Route("ListarLivros")]
    public IActionResult Get()
    {
        var books = _bookAppService.ListarLivros();
        if (books != null && books.Any())
            return StatusCode(200, new { message = "Livros(s) encontrado(s)", quantidade = books.Count(), books });

        return BadRequest(new { message = "Nenhum livro encontrado." });
    }

    [HttpPost]
    [Route("CriarBook")]
    public IActionResult Post([FromBody] CriarBookDto dto)
    {
        try
        {
            _bookAppService.CriarBook(dto);
            return StatusCode(201, new { message = "Book criado com sucesso." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro ao criar book.", erro = ex.Message });
        }
    }
}