using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ConcreteState : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
