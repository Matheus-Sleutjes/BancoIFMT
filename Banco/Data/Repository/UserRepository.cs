using Banco.Data.Content;
using Banco.Models;
using Microsoft.EntityFrameworkCore;

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

	public UserModel Get(LoginModel request) 
	{
		return _context.Users.AsNoTracking().Where(x => x.UserName == request.Username).FirstOrDefault();
	}

    public UserModel Get(int id)
    {
        return _context.Users.AsNoTracking().Where(x => x.UserId == id).FirstOrDefault();
    }

	public void Update(int id, LoginModel request)
	{
		var model = Get(id);
		//_context.Users.Update();
	}
}
