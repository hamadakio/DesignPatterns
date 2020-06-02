using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Concrete ClassB \n-PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Concrete ClassB \n-PrimitiveOperation2()");
        }
    }
}
