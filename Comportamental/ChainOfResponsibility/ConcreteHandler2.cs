using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} Handle Request {1}", GetType().Name, request);
            }
            else if (Sucessor != null)
            {
                Sucessor.HandleRequest(request);
            }
        }
    }
}
