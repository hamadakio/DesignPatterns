using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Canal de Culinaria";
        }

        public string Status()
        {
            return "MasterChef";
        }
    }
}
