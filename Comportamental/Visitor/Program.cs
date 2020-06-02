using System;

namespace Visitor
{
    class Program
    {   //define uma nova operaçao para uma classe sem alteraçao
        static void Main(string[] args)
        {
            ObjectEstruture objectEstruture = new ObjectEstruture();
            objectEstruture.Anexar(new ConcreteElementA());
            objectEstruture.Anexar(new ConcreteElementB());

            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();


            objectEstruture.Accept(visitor1);
            objectEstruture.Accept(visitor2);

        }
    }
}
