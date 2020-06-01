using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >=0 && request <10)
            {
                Console.WriteLine("{0} Handle Request {1}",GetType().Name,request);
            }
            else if (Sucessor != null)
            {
                Sucessor.HandleRequest(request);
            }
            
        }
    }
}
