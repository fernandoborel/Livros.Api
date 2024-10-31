using Livros.Domain.Interfaces.Repositories;
using Livros.Domain.Interfaces.Services;

namespace Livros.Domain.Services;

public class UserDomainService : IUserDomainService
{
    private readonly IUserRepository _userRepository;

    public UserDomainService(IUserRepository userRepository)
       => _userRepository = userRepository;

    public void CriarUser(User user)
    {
        _userRepository.Create(user);
    }

    public List<User> GetUsers()
    {
        return _userRepository.GetAll();
    }

    public void Dispose()
     => _userRepository.Dispose();
}