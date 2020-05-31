using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();
        

        public void ArmaFogo()
        {
            //next = gera um numero aleatorio X vezes 

            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Tanque inimigo deu {0} de dano" , danoAtaque);
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine("Tanque Inimigo andou {0} unidades" , movimento);
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine("O piloto {0} esta no comando do tanque",piloto);
        }
    }
}
