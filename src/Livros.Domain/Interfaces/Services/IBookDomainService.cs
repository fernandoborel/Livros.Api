namespace Livros.Domain.Interfaces.Services;

public interface IBookDomainService : IDisposable
{
    void CriarBook(Book book);
    List<Book> ListarLivros();
}