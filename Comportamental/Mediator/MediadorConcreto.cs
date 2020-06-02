using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        private ColegaConcreto1 colega1;
        private ColegaConcreto2 colega2;

        public ColegaConcreto1 Colega1 { set { colega1 = value; } }
        public ColegaConcreto2 Colega2 { set { colega2 = value; } }

        public override void Enviar(string mensagem, Colega colega)
        {
            if (colega == colega1)
            {
                colega2.Notificar(mensagem);
            }
            else
            {
                colega1.Notificar(mensagem);
            }
        }
    }
}
