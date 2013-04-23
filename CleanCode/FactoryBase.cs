using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanCode
{
    public class FactoryBase
    {
        public FactoryBase()
        {
 
        }

        public T GetInstance<T>() where T : new()
        {
            return new T();
        }
    }
}