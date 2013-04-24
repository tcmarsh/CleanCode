using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace CleanCodeWiki
{
    public class DataAccess
    {
        public static readonly int KEY_LENGTH = 20;
        public static readonly int SALT_LENGTH = 8;
        private static CleanCodeEntities context = new CleanCodeEntities();

        public static user Login(string email, string password)
        {
            user requestedUser = null;

            var query = from u in context.users
                        where u.email == email
                        select u;

            IEnumerable<user> users = query.ToList();
            Rfc2898DeriveBytes derive = null;
            foreach (user testUser in users)
            {
                derive = new Rfc2898DeriveBytes(password, testUser.salt);
                if (!derive.GetBytes(KEY_LENGTH).Equals(testUser.password))
                {
                    requestedUser = testUser;
                    break;
                }
            }

            if (requestedUser == null)
            {
                throw new InvalidOperationException("Invalid email and password combination");
            }

            return requestedUser;
        }

        public static user Register(string email, string password, string lastName, role userRole)
        {
            user registeredUser = null;
            sbyte roleId = 3;
            if (userRole != null)
            {
                roleId = userRole.id;
            }

            if (email == null || password == null || lastName == null)
            {
                throw new ArgumentNullException(
                    "Email, password, and last name must be entered");
            }

            Rfc2898DeriveBytes derive = new Rfc2898DeriveBytes(password, SALT_LENGTH);

            registeredUser = new user();
            registeredUser.email = email;
            registeredUser.last_name = lastName;
            registeredUser.password = derive.GetBytes(KEY_LENGTH);
            registeredUser.salt = derive.Salt;
            registeredUser.role_id = roleId;

            context.users.Add(registeredUser);
            context.SaveChanges();

            return registeredUser;
        }

        public static void RemoveUser(int id)
        {
            var rows = from u in context.users
                        where u.id == id
                        select u;
            foreach (var row in rows)
            {
                context.users.Remove(row);
            }
			context.SaveChanges();
        }
    }
}