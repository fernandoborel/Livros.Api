namespace Livros.Domain.Interfaces.Services;

public interface IUserDomainService : IDisposable
{
    void CriarUser(User user);
    List<User> GetUsers();
}