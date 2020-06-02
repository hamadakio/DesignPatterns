using System;

namespace Observer
{   //uma maneira de notificar a mudanca para um numero de classes 
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar(new ObservadorConcreto("X",s));
            s.Anexar(new ObservadorConcreto("Y", s));
            s.Anexar(new ObservadorConcreto("Z", s));

            s.EstadoAssunto = "ABC";
            s.Notificar();
        }
    }
}
