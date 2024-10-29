namespace Livros.Domain.Interfaces.Services;

public interface IAuthorDomainService : IDisposable
{
    void CriarAutor(Author author);
    List<Author> ListarAutores();
}