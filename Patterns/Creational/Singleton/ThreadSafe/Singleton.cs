using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Singleton.ThreadSafe
{
    class Singleton
    {
        private static Singleton _singleton = null;
        private static readonly object _lock = new object();

        public static Singleton Instance()
        {
            lock (_lock)
                if (_singleton == null)
                    lock (_lock)
                        _singleton = new Singleton();
            return _singleton;
        }
    }
}
