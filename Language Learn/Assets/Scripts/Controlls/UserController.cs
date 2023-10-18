using UnityEngine;
using Zenject;

public class UserController
{ 
	private User _user;
	public User User => _user;

	public void AuthorizeUser(User user)
	{
		_user = user;
	}

	//public void AuthorizeUser(IAuthorizationData data)
	//{
	//	_user = new User();
	//}
}
