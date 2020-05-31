using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //Objeto a ser Adaptado
    //Adaptee
    public class RoboInimigo 
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int Ataque = this.gerador.Next(10) + 1;
            Console.WriteLine("O inimigo causou {0} de dano com o ataque Esmagar com as Maos" , Ataque);
        }

        public void Andar()
        {
            int Movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("O robo inimigo andou {0} unidades",Movimento);
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("O robo inimigo vai contra o {0}",piloto);
        }
    }
}
