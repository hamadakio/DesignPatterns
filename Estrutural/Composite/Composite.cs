using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Composite : Componente
    {
        //classe que monta a arvore de estrururas

        private List<Componente> filhos = new List<Componente>();

        public Composite(string nome) : base(nome)
        {
        }

        public override void Add(Componente c)
        {
            filhos.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            //escreve uma linha , com o traço "-" + profundidade + nome
            Console.WriteLine(new string ('-',profundidade) + Nome);

            foreach (Componente filho in filhos)
            {
                filho.Mostrar(profundidade +2);
            }
        }

        public override void Remover(Componente c)
        {
            filhos.Remove(c);
        }
    }
}
