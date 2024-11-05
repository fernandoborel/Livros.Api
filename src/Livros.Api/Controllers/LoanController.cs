using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Livros.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoanController : ControllerBase
{
    private readonly ILoanAppService _loanAppService;

    public LoanController(ILoanAppService loanAppService)
      => _loanAppService = loanAppService;

    [HttpGet]
    [Route("ListarEmprestimos")]
    public IActionResult Get()
    {
        var loans = _loanAppService.ListarLoans();
        if (loans != null && loans.Any())
            return StatusCode(200, new { message = "Empréstimo(s) encontrado(s)", quantidade = loans.Count(), loans });

        return BadRequest(new { message = "Nenhum empréstimo encontrado." });
    }

    [HttpPost]
    [Route("CriarEmprestimo")]
    public IActionResult Post([FromBody] CriarLoanDto criarLoanDto)
    {
        try
        {
            _loanAppService.CriarLoan(criarLoanDto);
            return StatusCode(201, new { message = "Empréstimo criado com sucesso." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro ao criar empréstimo.", erro = ex.Message });
        }
    }
}