using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCode;

namespace CleanCodeTest
{
    [TestClass]
    public class ArticleUtilTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FactoryBase fBase = new FactoryBase();
            TagFactory tagFactory = fBase.GetInstance<TagFactory>();
            ArticleFactory articleFactory = fBase.GetInstance<ArticleFactory>();
            
            var tag = tagFactory.GetInstance();
            Assert.IsInstanceOfType(tag, typeof(Tag));
            
            var article = articleFactory.GetInstance();
            Assert.IsInstanceOfType(article, typeof(Article));
            
            //article.AddTag(tag);
        }
    }
}
