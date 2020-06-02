using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ColegaConcreto2 : Colega
    {
        public ColegaConcreto2(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem,this);
        }

        public void Notificar(string msg)
        {
            Console.WriteLine("Mensagem do colega 2: {0}",msg);
        }
    }
}
