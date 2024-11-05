using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Livros.Domain.Interfaces.Services;

namespace Livros.Application.Services;

public class LoanAppService : ILoanAppService
{
    private readonly ILoanDomainService _loanDomainService;

    public LoanAppService(ILoanDomainService loanDomainService)
       => _loanDomainService = loanDomainService;

    public void CriarLoan(CriarLoanDto criarLoanDto)
    {
        _loanDomainService.CriarLoan(criarLoanDto.UserId, criarLoanDto.BookId);
    }

    public List<LoanDto> ListarLoans()
    {
        var loans = _loanDomainService.ListarLivros();
        return loans.Select(l => new LoanDto
        {
            Id = l.Id,
            UserId = l.UserId,
            LoanDate = l.LoanDate,
            ReturnDate = l.ReturnDate
        }).ToList();
    }

    public void Dispose()
       => _loanDomainService?.Dispose();
}