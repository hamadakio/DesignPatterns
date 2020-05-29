using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fornece uma interface para criar familias de objetos relacionados ou 
            //dependentes sem especificar suas classes concretas

            Carro carro1 = ExecutaAbstractFactory.montaCarro("Luxo");
            Carro carro2 = ExecutaAbstractFactory.montaCarro("Popular");

            Console.ReadKey();
        }
    }
}
