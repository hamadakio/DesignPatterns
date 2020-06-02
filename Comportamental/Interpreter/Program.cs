using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        //uma maneira de incluir elementos de linguagem em um programa
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";

            Context context = new Context(romano);

            List<Expressao> expressoes = new List<Expressao>();

            expressoes.Add(new MilharesExpressao());
            expressoes.Add(new CentenasExpressao());
            expressoes.Add(new DezenasExpressao());
            expressoes.Add(new UnidadeExpressao());

            foreach (Expressao exp in expressoes)
            {
                exp.Interpretador(context);
            }

            Console.WriteLine("{0} = {1}" , romano , context.Output);
        }
    }
}
