using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //Adaptador
    //adapta o objeto robo com o tanque
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;
        //passa para o metodo construtor o metodo que sera adaptado

        public RoboInimigoAdapter(RoboInimigo new_robo)
        {
            this.robo = new_robo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.Andar();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
