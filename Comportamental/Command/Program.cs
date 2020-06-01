using System;

namespace Command
{
    //encapsula uma solicitaçao de comando como um objeto 
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteComand();

        }
    }
}
