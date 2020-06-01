using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Foco em reaproveitamento de objetos sem necessidade de instanciar varias vezes
            Console.WriteLine("===# Flyweight #===");
            FabricaFlyweight fabrica = new FabricaFlyweight();

            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine("Qual Tartaruga enviar para a tela :");
                cor = Console.ReadLine();
                Console.WriteLine("");
                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostrar(cor);

                Console.WriteLine("===============================");
            }


        }
    }
}
