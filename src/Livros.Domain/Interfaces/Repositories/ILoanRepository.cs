using Livros.Domain.Core;

namespace Livros.Domain.Interfaces.Repositories;

public interface ILoanRepository : IBaseRepository<Loan>
{
    void CreateLoan(int userId, int bookId);
}