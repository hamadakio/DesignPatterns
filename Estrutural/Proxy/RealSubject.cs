using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealSubject : Subject
    {
        public override void Requisicao()
        {
            Console.WriteLine("Chamando um RealSubject.Request()");
        }
    }
}
