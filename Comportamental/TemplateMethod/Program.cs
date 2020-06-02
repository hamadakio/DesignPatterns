using System;

namespace TemplateMethod
{
    class Program
    {   //adia as etapas exatas de um algorito para uma subclasse
        static void Main(string[] args)
        {
            AbstractClass abstractClassA = new ConcreteClassA();
            abstractClassA.TemplateMethod();

            AbstractClass abstractClassB = new ConcreteClassA();
            abstractClassB.TemplateMethod();

        }
    }
}
