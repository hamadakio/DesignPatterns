using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            Condicao = "Tartaruga sem casco";
            Acao = "Em movimento";
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
