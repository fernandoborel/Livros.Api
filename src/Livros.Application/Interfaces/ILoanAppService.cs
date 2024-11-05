using Livros.Application.Dtos;

namespace Livros.Application.Interfaces;

public interface ILoanAppService : IDisposable
{
    void CriarLoan(CriarLoanDto criarLoanDto);
    List<LoanDto> ListarLoans();
}