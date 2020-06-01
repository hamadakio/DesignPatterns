using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
       private SubSistema1 um ;
       private SubSistema2 dois ;
       private SubSistema3 tres ;

        public Facade()
        {
            um = new SubSistema1();
            dois = new SubSistema2();
            tres = new SubSistema3();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMetodoA() ------");
            um.Metodo1();
            dois.Metodo2();   
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMetodoB() ------");
            um.Metodo1();
            tres.Metodo3();
        }
    }
}
