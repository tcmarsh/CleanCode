using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCode;

namespace CleanCodeTest
{
    [TestClass]
    public class FactoryBaseTest
    {
        [TestMethod]
        public void testGetNewInstance()
        {
            var factoryBase = new FactoryBase();

            var articleFactory = factoryBase.GetInstance<ArticleFactory>();

            Assert.IsInstanceOfType(articleFactory, typeof(ArticleFactory));

            var userFactory = factoryBase.GetInstance<UserFactory>();

            Assert.IsInstanceOfType(userFactory, typeof(UserFactory));

            var tagFactory = factoryBase.GetInstance<TagFactory>();

            Assert.IsInstanceOfType(tagFactory, typeof(TagFactory));
        }
    }
}
