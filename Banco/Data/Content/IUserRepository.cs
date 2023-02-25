using Banco.Models;

namespace Banco.Data.Content;

public interface IUserRepository
{
    void Create(LoginModel request);
    UserModel Get(LoginModel request);
    UserModel Get(int id);
    void Update(int id, LoginModel request);
}
