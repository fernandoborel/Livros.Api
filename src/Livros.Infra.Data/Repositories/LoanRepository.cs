using Livros.Domain;
using Livros.Domain.Interfaces.Repositories;
using Livros.Infra.Data.Context;

namespace Livros.Infra.Data.Repositories;

public class LoanRepository : BaseRepository<Loan>, ILoanRepository
{
    private readonly SqlServerContext _context;

    public LoanRepository(SqlServerContext context) : base(context)
    {
        _context = context;
    }

    public void CreateLoan(int userId, int bookId)
    {
        // Verifica se o livro está disponível
        var book = _context.Books.FirstOrDefault(b => b.Id == bookId && b.IsAvailable);
        if (book == null)
        {
            throw new InvalidOperationException("O livro não está disponível para empréstimo.");
        }

        // Cria um novo empréstimo
        var loan = new Loan
        {
            UserId = userId,
            LoanDate = DateOnly.FromDateTime(DateTime.Now),
            ReturnDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30))
        };

        _context.Loans.Add(loan);
        _context.SaveChanges();

        book.IsAvailable = false;
        _context.SaveChanges();
    }
}