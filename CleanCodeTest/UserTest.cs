using System;
using CleanCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestTrackViewed()
        {
            FactoryBase fBase = new FactoryBase();

            var userFactory = fBase.GetInstance<UserFactory>();

            var articleFactory = fBase.GetInstance<ArticleFactory>();

            var user = userFactory.GetInstance();

            var article = articleFactory.GetInstance();

            user.TrackViewed(article);

            Assert.IsTrue(user.ViewedArticles.Contains(article));
        }

        [TestMethod]
        public void TestTrackEdited()
        {
            FactoryBase fBase = new FactoryBase();

            var userFactory = fBase.GetInstance<UserFactory>();

            var articleFactory = fBase.GetInstance<ArticleFactory>();

            var user = userFactory.GetInstance();

            var article = articleFactory.GetInstance();

            user.TrackEdited(article);

            Assert.IsTrue(user.EditedArticles.Contains(article));
        }

        [TestMethod]
        public void TestTrackAuthored()
        {
            FactoryBase fBase = new FactoryBase();

            var userFactory = fBase.GetInstance<UserFactory>();

            var articleFactory = fBase.GetInstance<ArticleFactory>();

            var user = userFactory.GetInstance();

            var article = articleFactory.GetInstance();

            user.TrackAuthored(article);

            Assert.IsTrue(user.AuthoredArticles.Contains(article));
        }
    }
}
