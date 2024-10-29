using Livros.Domain;
using Livros.Domain.Interfaces.Repositories;
using Livros.Infra.Data.Context;

namespace Livros.Infra.Data.Repositories;

public class LoanRepository : BaseRepository<Loan>, ILoanRepository
{
    private readonly SqlServerContext _context;

    public LoanRepository(SqlServerContext context) : base(context)
      =>  _context = context;
}