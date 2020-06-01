using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Executar()
        {
            receiver.Action();
        }
    }
}
