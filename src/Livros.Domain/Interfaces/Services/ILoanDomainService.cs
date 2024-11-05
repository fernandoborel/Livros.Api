namespace Livros.Domain.Interfaces.Services;

public interface ILoanDomainService : IDisposable
{
    void CriarLoan(int userId, int bookId);
    List<Loan> ListarLivros();
}