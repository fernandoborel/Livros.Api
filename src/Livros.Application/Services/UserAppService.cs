using AutoMapper;
using Livros.Application.Dtos;
using Livros.Application.Interfaces;
using Livros.Domain;
using Livros.Domain.Interfaces.Services;

namespace Livros.Application.Services;

public class UserAppService : IUserAppService
{
    private readonly IUserDomainService _userDomainService;
    private readonly IMapper _mapper;

    public UserAppService(IUserDomainService userDomainService, IMapper mapper)
    {
        _userDomainService = userDomainService;
        _mapper = mapper;
    }

    public void CriarUser(CriarUserDto dto)
    {
        var user = _mapper.Map<User>(dto);
        _userDomainService.CriarUser(user);
    }

    public List<User> ListarUsers()
    {
        return _userDomainService.GetUsers();
    }

    public void Dispose()
        => _userDomainService.Dispose();
}