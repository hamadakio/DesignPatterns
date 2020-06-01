using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler Sucessor;

        public void SetSucessor(Handler sucessor)
        {
            Sucessor = sucessor;
        }

        public abstract void HandleRequest(int request);
    }
}
