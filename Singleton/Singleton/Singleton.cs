using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //sealed nao permite a classe ser herdada
    public sealed class Singleton
    {
        private static Singleton Instancia = null;

        public static Singleton GetInstancia
        { 
            //garante que exista apenas uma instancia do objeto
            get
            {
                if (Instancia == null)
                {
                    Instancia = new Singleton();
                    Console.WriteLine("Bola em Jogo");
                }

                return Instancia;
            }

        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
        
    }
}
