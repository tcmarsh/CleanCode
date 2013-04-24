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

            derive = new Rfc2898DeriveBytes(password, DataAccess.SALT_LENGTH);
            salt = derive.Salt;

            newUser = new user();
            newUser.email = email;
            newUser.last_name = "test";
            newUser.salt = salt;
            newUser.password = derive.GetBytes(DataAccess.KEY_LENGTH);
            newUser.role_id = 3;

            newUser = context.users.Add(newUser);
            context.SaveChanges();
        }
		[TestCleanup]
		public void Cleanup()
		{
			var users = from u in context.users
						where u.email == email
						select u;
			foreach (user user in users)
			{
				context.users.Remove(user);
			}
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

        [TestMethod]
        public void RegisterTest()
        {
            user testUser = DataAccess.Register("another" + email, password, "another", null);
            
            Assert.IsNotNull(testUser);
            Assert.AreNotEqual(testUser.email, newUser.email);

            if (testUser != null)
            {
                DataAccess.RemoveUser(testUser.id);
            }
        }
    }
}
