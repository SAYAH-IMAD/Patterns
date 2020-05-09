using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.ChaineOfResponsability
{

    public abstract class Handler
    {
        public Handler Successor { protected get; set; }

        public abstract void HandleRequest(int request);
    }

    public class ConctreatHandler1 : Handler
    {

        public override void HandleRequest(int request)
        {
            if(request < 10)
            {
                // process
            }
            else
            {
                this.Successor.HandleRequest(request);
            }
        }
    }

    public class ConctreatHandler2 : Handler
    {

        public override void HandleRequest(int request)
        {
            if (request >= 10)
            {
                // process
            }
            else
            {
                this.Successor.HandleRequest(request);
            }
        }
    }
}
