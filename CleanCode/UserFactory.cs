using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCode
{
    public class UserFactory : FactoryBase
    {
        public UserFactory()
        {

        }

        public User GetInstance()
        {
            return new User();
        }
    }
}