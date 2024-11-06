using Livros.Application.Interfaces;
using Livros.Application.Mappings;
using Livros.Application.Services;
using Livros.Domain.Interfaces.Repositories;
using Livros.Domain.Interfaces.Services;
using Livros.Domain.Services;
using Livros.Infra.Data.Context;
using Livros.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Livros.Api;

public static class Setup
{
    public static void AddRegisterServices(this WebApplicationBuilder builder)
    {
        #region Author

        builder.Services.AddScoped<IAuthorAppService, AuthorAppService>();
        builder.Services.AddScoped<IAuthorDomainService, AuthorDomainService>();
        builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

        #endregion

        #region Book

        builder.Services.AddScoped<IBookAppService, BookAppService>();
        builder.Services.AddScoped<IBookDomainService, BookDomainService>();
        builder.Services.AddScoped<IBookRepository, BookRepository>();

        #endregion

        #region User

        builder.Services.AddScoped<IUserAppService, UserAppService>();
        builder.Services.AddScoped<IUserDomainService, UserDomainService>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();

        #endregion

        #region Loan

        builder.Services.AddScoped<ILoanAppService, LoanAppService>();
        builder.Services.AddScoped<ILoanDomainService, LoanDomainService>();
        builder.Services.AddScoped<ILoanRepository, LoanRepository>();

        #endregion
    }

    public static void AddEntityFrameworkServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("LibraryDB");
        builder.Services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connectionString));
    }

    public static void AddAutoMapperServices(this WebApplicationBuilder builder)
       => builder.Services.AddAutoMapper(typeof(DtoToEntity));
}