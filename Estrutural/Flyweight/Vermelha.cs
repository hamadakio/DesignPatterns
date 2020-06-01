using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    //classe concreta = implementada
    public class Vermelha : Tartaruga
    {
        public Vermelha()
        {
            Condicao = "Tartaruga dentro do casco";
            Acao = "Rodando no chao";
        }

        public override void Mostrar(string cor)
        {
            Cor = cor;
            Console.WriteLine("Condicao: {0}", Condicao);
            Console.WriteLine("Ação: {0}",Acao);
            Console.WriteLine("Cor? {0}", Cor.ToUpper());
        }
    }
}
