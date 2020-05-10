using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Singleton.Basic
{
    class Singleton
    {
        private static Singleton _singleton = null;
        
        public static Singleton Instance()
        {
            if (_singleton == null)
                _singleton = new Singleton();
            return _singleton;
        }
    }
}
