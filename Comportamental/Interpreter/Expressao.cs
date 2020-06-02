using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public abstract class Expressao
    {
        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicar();
        public void Interpretador(Context context)
        {
            if (context.Input.Length == 0)
            {
                return;
            }

            if (context.Input.StartsWith(Nove()))
            {
                context.Output += (9 * Multiplicar());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Cinco()))
            {
                context.Output += (5 * Multiplicar());
                context.Input = context.Input.Substring(1);
            }
            else if (context.Input.StartsWith(Quatro()))
            {
                context.Output += (4 * Multiplicar());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Um()))
            {
                context.Output += (1 * Multiplicar());
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(Um()))
            {
                context.Output += (1 * Multiplicar());
                context.Input = context.Input.Substring(1);
            }
        }

    }
}
