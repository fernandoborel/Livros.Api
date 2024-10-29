using Livros.Domain.Interfaces.Repositories;
using Livros.Domain.Interfaces.Services;

namespace Livros.Domain.Services;

public class AuthorDomainService : IAuthorDomainService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorDomainService(IAuthorRepository authorRepository)
        => _authorRepository = authorRepository;

    public void CriarAutor(Author author)
    {
        _authorRepository.Create(author);
    }

    public List<Author> ListarAutores()
    {
        return _authorRepository.GetAll();
    }

    public void Dispose()
       => _authorRepository?.Dispose();
}