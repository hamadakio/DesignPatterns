using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca ItemBiblioteca;

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            ItemBiblioteca = itemBiblioteca;
        }

        public override void Exibir()
        {
            ItemBiblioteca.Exibir();
        }
    }
}
