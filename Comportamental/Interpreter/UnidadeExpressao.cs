using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class UnidadeExpressao : Expressao
    {
        public override string Cinco()
        {
            return "V";
        }

        public override int Multiplicar()
        {
            return 1;
        }

        public override string Nove()
        {
            return "IX";
        }

        public override string Quatro()
        {
            return "IV";
        }

        public override string Um()
        {
            return "I";
        }
    }
}
