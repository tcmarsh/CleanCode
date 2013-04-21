using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeWiki;
using System.Security.Cryptography;

namespace CleanCodeWikiTest
{
    [TestClass]
    public class DataAccessTest
    {
        [TestInitialize]
        public void Initialize()
        {
            context = new CleanCodeEntities();
            email = "test@test.com";
            password = "testpassword";

            derive = new Rfc2898DeriveBytes(password, 8);
            salt = derive.Salt;

            newUser = new user();
            newUser.email = email;
            newUser.last_name = "test";
            newUser.salt = salt;
            newUser.password = derive.GetBytes(8);
            newUser.role_id = 3;

            newUser = context.users.Add(newUser);
            context.SaveChanges();
        }
       
        private string email;
        private string password;
        private byte[] salt;
        private Rfc2898DeriveBytes derive;
        private user newUser;
        private CleanCodeEntities context;

        [TestMethod]
        public void LoginTest()
        {

            user loginUser = DataAccess.Login(email, password);

            context.users.Remove(newUser);
            context.SaveChanges();

            Assert.IsNotNull(loginUser);

            Assert.AreEqual(newUser.email, loginUser.email);

            try
            {
                loginUser = DataAccess.Login(email, "not" + password);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Catching the expected invalid operation exception");
                Console.WriteLine(exception);
                loginUser = null;
            }

            Assert.IsNull(loginUser);
        }
    }
}
