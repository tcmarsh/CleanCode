using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCode
{
    public class ArticleFactory : FactoryBase
    {
        public ArticleFactory()
        { 
        }

        public Article GetInstance()
        {
            return new Article();
        }
    }
}