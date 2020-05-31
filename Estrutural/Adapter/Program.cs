using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tanque = new TanqueInimigo();
            RoboInimigo robo = new RoboInimigo();

            //passa o robo criado para o adaptador
            IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(robo);

            Console.WriteLine("===ROBO===");
            robo.ReagirContraHumano("Humano");
            robo.Andar();
            robo.EsmagarComMaos();

            Console.WriteLine("===Tanque===");
            tanque.ArmaFogo();
            tanque.Movimenta();
            tanque.Pilotar("Piloto");

            Console.WriteLine("===RoboAdaptado===");
            robo_adapter.Movimenta();
            robo_adapter.ArmaFogo();
            robo_adapter.Pilotar("Adapter");

        }
    }
}
