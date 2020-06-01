using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            Condicao = "Tartaruga fora do casco";
            Acao = "Parada";
        }

        public override void Mostrar(string cor)
        {
            Cor = cor;
            Console.WriteLine("Condicao: {0}", Condicao);
            Console.WriteLine("Ação: {0}", Acao);
            Console.WriteLine("Cor? {0}", Cor.ToUpper());
        }
    }
}
