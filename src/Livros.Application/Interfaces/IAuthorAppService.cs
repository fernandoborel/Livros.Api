using Livros.Application.Dtos;
using Livros.Domain;

namespace Livros.Application.Interfaces;

public interface IAuthorAppService : IDisposable
{
    void CriarAutor(CriarAuthorDto author);
    List<Author> ListarAutores();
}