using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.Singleton.Lazy_Loading
{
    class Singleton
    {
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => lazyInstance.Value;
    }
}
