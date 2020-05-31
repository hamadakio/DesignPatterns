using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IAtaqueInimigo
    {

        void ArmaFogo();
        void Movimenta();
        void Pilotar(string piloto);

    }
}
