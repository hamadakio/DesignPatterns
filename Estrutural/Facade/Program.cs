using System;

namespace Facade
{
    //Uma interface manipula diversos subsistemas
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MetodoA();
            facade.MetodoB();
        }
    }
}
