using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Folha : Componente
    {
        //para remover ou adicionar uma folha é necessario add ou remov todos os itens da mesma

        public Folha(string nome) : base(nome)
        {
        }

        public override void Add(Componente c)
        {
            Console.WriteLine("Nao foi possivel adicionar a folha");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string ('-',profundidade)+Nome);
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Nao é possivel remover a folha");
        }
    }
}
