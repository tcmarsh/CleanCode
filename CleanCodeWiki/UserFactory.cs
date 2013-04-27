using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace CleanCodeWiki
{
	public class UserFactory
	{
		public static user createUser(string email, string password, string lastName, sbyte role)
		{
			user createdUser = new user();
			createdUser.email = email;

			Rfc2898DeriveBytes derive = new Rfc2898DeriveBytes(password, 8);

			createdUser.password = derive.GetBytes(20);
			createdUser.salt = derive.Salt;
			createdUser.last_name = lastName;
			createdUser.role_id = role;

			return createdUser;
		}
	}
}