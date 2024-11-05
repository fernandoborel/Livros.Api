using AutoMapper;
using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Livros.Domain;
using Livros.Domain.Interfaces.Services;

namespace Livros.Application.Services;

public class BookAppService : IBookAppService
{
    private readonly IBookDomainService _bookDomainService;
    private readonly IMapper _mapper;

    public BookAppService(IBookDomainService bookDomainService, IMapper mapper)
    {
        _bookDomainService = bookDomainService;
        _mapper = mapper;
    }

    public void CriarBook(CriarBookDto dto)
    {
        var book = _mapper.Map<Book>(dto);
        _bookDomainService.CriarBook(book);
    }

    public List<BookResponseDto> ListarLivros()
    {
        var books = _bookDomainService.ListarLivros();
        return books.Select(b => new BookResponseDto
        {
            Id = b.Id,
            Title = b.Title,
            IsAvailable = b.IsAvailable,
            AuthorName = b.Author.Name
        }).ToList();
    }

    public void Dispose()
        => _bookDomainService.Dispose();
}