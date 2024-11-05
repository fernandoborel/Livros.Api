using Livros.Domain;
using Livros.Domain.Interfaces.Repositories;
using Livros.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Livros.Infra.Data.Repositories;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    private readonly SqlServerContext _context;

    public BookRepository(SqlServerContext context) : base(context)
       => _context = context;

    public override List<Book> GetAll()
    {
        return _context.Books.Include(x => x.Author).ToList();
    }
}