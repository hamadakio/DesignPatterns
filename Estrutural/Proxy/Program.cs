using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //proxy chama o realsubject como se fosse um intermediario

            Proxy proxy = new Proxy();

            proxy.Requisicao();

        }
    }
}
