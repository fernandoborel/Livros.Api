using Livros.Application.Dtos;

namespace Livros.Application.Interfaces;

public interface IBookAppService : IDisposable
{
    void CriarBook(CriarBookDto book);
    List<BookResponseDto> ListarLivros();
}