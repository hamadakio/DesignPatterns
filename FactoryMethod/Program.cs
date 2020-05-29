using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            Console.WriteLine("LiuKang | SubZero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha seu Personagem");
            string escolha = Console.ReadLine();

            //usa a interface para armazenar o que o metodo Fabrica vai armazenar
            //polimorfismo 
            IPersonagem personagem = factoryMethod.EscolherPersonagem(escolha);
            Console.WriteLine();
            Console.WriteLine("Voce vai jogar com :");
            //chama a funcao
            personagem.Escolhido();


        }
    }
}
