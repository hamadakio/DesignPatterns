using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ponte
            SmartTV TV = new SmartTV();

            Console.WriteLine("Selecione um canal");
            Console.WriteLine("1 - Filmes \n" +
                "2 - Documentarios \n" +
                "3 - Culinaria");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    TV.canal_atual = new Filme();
                    Console.Clear();
                    break;
                case '2':
                    TV.canal_atual = new Documentario();
                    Console.Clear();
                    break;
                case '3':
                    TV.canal_atual = new Culinaria();
                    Console.Clear();
                    break;
                default: TV.canal_atual = null;
                    break;
            }

            Console.WriteLine();
            TV.ExibeCanal();
            TV.PlayTV();
            

        }
    }
}
