using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace CleanCodeWiki
{
    public class DataAccess
    {
        public static user Login(string email, string password)
        {
            CleanCodeEntities context = new CleanCodeEntities();
            user requestedUser = null;

            var query = from u in context.users
                        where u.email == email
                        select u;

            IEnumerable<user> users = query.ToList();
            Rfc2898DeriveBytes derive = null;
            foreach (user testUser in users)
            {
                derive = new Rfc2898DeriveBytes(password, testUser.salt);
                if (!derive.GetBytes(8).Equals(testUser.password))
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
    }
}