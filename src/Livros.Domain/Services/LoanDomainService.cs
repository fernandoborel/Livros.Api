using Livros.Domain.Interfaces.Repositories;
using Livros.Domain.Interfaces.Services;

namespace Livros.Domain.Services;

public class LoanDomainService : ILoanDomainService
{
    private readonly ILoanRepository _loanRepository;

    public LoanDomainService(ILoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    public void CriarLoan(int userId, int bookId)
    {
        _loanRepository.CreateLoan(userId, bookId);
    }

    public List<Loan> ListarLivros()
    {
        return _loanRepository.GetAll().ToList();
    }

    public void Dispose()
       => _loanRepository?.Dispose();
}