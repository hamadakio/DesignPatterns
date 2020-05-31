using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bridge
{
    public class Filme : ICanal
    {
        public string Canal()
        {
            return "Canal de Filmes";
        }

        public string Status()
        {
            return "Filme : Vingadores";
        }
    }
}
