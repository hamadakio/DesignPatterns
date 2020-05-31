using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //permite criar uma hierarqia de objetos
            Composite raiz = new Composite("raiz");

            raiz.Add(new Folha("Folha 1"));
            raiz.Add(new Folha("Folha 2"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Folha("Folha A1"));
            comp.Add(new Folha("Folha A2"));

            raiz.Add(comp);
            raiz.Add(new Folha("Folha B1"));

            Folha folha = new Folha("Folha D1");

            raiz.Add(folha);
           // raiz.Remover(folha);

            raiz.Mostrar(2);

        }
    }
}
