using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class ItemBiblioteca
    {
        public int NumCopias { get; set; }

        public abstract void Exibir();

    }
}
