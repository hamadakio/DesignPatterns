using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA
            (ConcreteElementA elementA);
        public abstract void VisitConcreteElementB
            (ConcreteElementB elementB);
    }
}
