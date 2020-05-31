using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return "Canal de Documentarios";
        }

        public string Status()
        {
            return "Documentario : Vale do Silicio";
        }
    }
}
