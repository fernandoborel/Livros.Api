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
    //public static void AddSwagger(this WebApplicationBuilder builder)
    //{
    //    builder.Services.AddSwaggerGen(s =>
    //    {
    //        s.SwaggerDoc("v1", new OpenApiInfo
    //        {
    //            Title = "Livros API",
    //            Version = "v1",
    //            Description = "API de Livros",
    //            Contact = new OpenApiContact
    //            {
    //                Name = "Fernando Borel",
    //                Email = "fernandomenezesborel@gmail.com",
    //                Url = new Uri("https://github.com/fernandoborel")
    //            }
    //        });

    //        s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    //        {
    //            Description = "Insira o token JWT sem a palavra 'Bearer'. Exemplo: '12345abcdef'",
    //            Name = "Authorization",
    //            In = ParameterLocation.Header,
    //            Type = SecuritySchemeType.Http,
    //            Scheme = "Bearer",
    //            BearerFormat = "JWT",
    //        });

    //        s.AddSecurityRequirement(new OpenApiSecurityRequirement
    //    {
    //        {
    //            new OpenApiSecurityScheme
    //            {
    //                Reference = new OpenApiReference
    //                {
    //                    Type = ReferenceType.SecurityScheme,
    //                    Id = "Bearer"
    //                },
    //                Scheme = "Bearer",
    //                Name = "Bearer",
    //                In = ParameterLocation.Header,
    //            },
    //            new List<string>()
    //        }
    //    });
    //    });
    //}

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
    }

    public static void AddEntityFrameworkServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("LibraryDB");
        builder.Services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connectionString));
    }

    public static void AddAutoMapperServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(DtoToEntity));
    }
}