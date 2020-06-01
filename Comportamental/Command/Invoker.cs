using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command _command) 
        {
            command = _command;
        }

        public void ExecuteComand()
        {
            command.Executar();
        }
    }
}
