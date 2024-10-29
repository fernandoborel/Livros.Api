using Livros.Domain;
using Livros.Domain.Interfaces.Repositories;
using Livros.Infra.Data.Context;

namespace Livros.Infra.Data.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly SqlServerContext _context;

    public UserRepository(SqlServerContext context) : base(context)
      => _context = context;
}