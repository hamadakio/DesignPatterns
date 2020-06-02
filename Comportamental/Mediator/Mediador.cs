using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Mediador
    {
        public abstract void Enviar(string mensagem , Colega colega);
    }
}
