using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Scorpion");
        }
    }
}
