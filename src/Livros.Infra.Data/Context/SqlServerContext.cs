using Livros.Domain;
using Livros.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Livros.Infra.Data.Context;

public class SqlServerContext : DbContext
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options) 
        : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorMap());
        modelBuilder.ApplyConfiguration(new BookMap());
        modelBuilder.ApplyConfiguration(new LoanMap());
        modelBuilder.ApplyConfiguration(new UserMap());
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Loan> Loans { get; set; }
    public virtual DbSet<User> Users { get; set; }
}