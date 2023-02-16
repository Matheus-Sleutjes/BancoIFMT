using Banco.Data.Content;
using Banco.Models;

namespace Banco.Data.Repository;

public class UserRepository : IUserRepository
{
	private readonly BancoContext _context;
	public UserRepository(BancoContext context)
	{
			_context = context;
	}

	public void Create(LoginModel request)
	{
		var user = new UserModel(request.Username, request.Password);
		_context.Users.Add(user);	
		_context.SaveChanges();
	}
}
