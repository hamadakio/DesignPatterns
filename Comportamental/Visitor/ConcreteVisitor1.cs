using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("{0} visitado por {1}", 
                elementA.GetType().Name,this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("{0} visitado por {1}",
                elementB.GetType().Name, this.GetType().Name);
        }
    }
}
