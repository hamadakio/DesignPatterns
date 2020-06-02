using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class DezenasExpressao : Expressao
    {
        public override string Cinco()
        {
            return "L";
        }

        public override int Multiplicar()
        {
            return 10;
        }

        public override string Nove()
        {
            return "XC";
        }

        public override string Quatro()
        {
            return "XL";
        }

        public override string Um()
        {
            return "X";
        }
    }
}
