using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCode
{
    public class TagFactory : FactoryBase
    {
        public TagFactory()
        {
        }

        public Tag GetInstance()
        {
            return new Tag();
        }
    }
}