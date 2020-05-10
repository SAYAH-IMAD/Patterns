using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Proxy
{

    interface ISubject
    {
        void Request();
    }

    class Proxy : ISubject
    {
        private readonly ISubject subject;

        public Proxy(ISubject subject)
        {
            this.subject = subject;
        }
        public void Request()
        {
            this.subject.Request();
        }
    }

    class Subject : ISubject
    {
        public void Request() { }
    }

}
