using System;

namespace State
{
    class Program
    {   //Altera o comportamento de um objeto quando seu estado é alterado
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteState());

            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
