using System;
using System.Reflection.Metadata;

namespace ChainOfResponsibility
{
    class Program
    {
        //maneira de passar uma requisicao por meio de uma cadeia de objetos
        static void Main(string[] args)
        {
            Handler H1 = new ConcreteHandler1();
            Handler H2 = new ConcreteHandler2();
            Handler H3 = new ConcreteHandler3();

            //cadeia de objetos
            H1.SetSucessor(H2);
            H2.SetSucessor(H3);

            int[] requests = {2,5,24,22,18,3,27,20 };

            foreach (int request in requests)
            {
                H1.HandleRequest(request);
            }

        }
    }
}
