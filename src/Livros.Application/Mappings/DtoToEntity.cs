using AutoMapper;
using Livros.Application.Dtos;
using Livros.Domain;

namespace Livros.Application.Mappings;

public class DtoToEntity : Profile
{
    public DtoToEntity()
    {
        CreateMap<CriarAuthorDto, Author>().ReverseMap();
        CreateMap<CriarBookDto, Book>().ReverseMap();
    }
}