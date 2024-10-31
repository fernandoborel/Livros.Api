using Livros.Application.Dtos;
using Livros.Domain;

namespace Livros.Application.Interfaces;

public interface IBookAppService : IDisposable
{
    void CriarBook(CriarBookDto book);
    List<Book> ListarLivros();
}