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

    public List<Book> ListarLivros()
    {
        return _bookDomainService.ListarLivros();
    }

    public void Dispose()
        => _bookDomainService.Dispose();
}