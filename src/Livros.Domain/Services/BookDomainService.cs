using Livros.Domain.Interfaces.Repositories;
using Livros.Domain.Interfaces.Services;

namespace Livros.Domain.Services;

public class BookDomainService : IBookDomainService
{
    private readonly IBookRepository _bookRepository;

    public BookDomainService(IBookRepository bookRepository)
       => _bookRepository = bookRepository;

    public void CriarBook(Book book)
    {
        _bookRepository.Create(book);
    }

    public List<Book> ListarLivros()
    {
        return _bookRepository.GetAll().ToList();
    }

    public void Dispose()
        => _bookRepository.Dispose();
}