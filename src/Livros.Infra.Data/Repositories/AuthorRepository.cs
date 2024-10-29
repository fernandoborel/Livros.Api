using Livros.Domain;
using Livros.Domain.Interfaces.Repositories;
using Livros.Infra.Data.Context;

namespace Livros.Infra.Data.Repositories;

public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
{
    private readonly SqlServerContext _context;

    public AuthorRepository(SqlServerContext context) : base(context)
       => _context = context;
}