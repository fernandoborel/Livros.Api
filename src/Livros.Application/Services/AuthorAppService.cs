using AutoMapper;
using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Livros.Domain;
using Livros.Domain.Interfaces.Services;

namespace Livros.Application.Services;

public class AuthorAppService : IAuthorAppService
{
    private readonly IAuthorDomainService _authorDomainService;
    private readonly IMapper _mapper;

    public AuthorAppService(IAuthorDomainService authorDomainService, IMapper mapper)
    {
        _authorDomainService = authorDomainService;
        _mapper = mapper;
    }

    public void CriarAutor(CriarAuthorDto dto)
    {
        var autor = _mapper.Map<Author>(dto);
        _authorDomainService.CriarAutor(autor);
    }

    public List<Author> ListarAutores()
    {
        return _authorDomainService.ListarAutores().ToList();
    }

    public void Dispose()
        => _authorDomainService.Dispose();

}
