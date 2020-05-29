using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton player_1 = Singleton.GetInstancia;
            player_1.Mensagem("Jogador1 : A Bola esta comigo");

            Singleton player_2 = Singleton.GetInstancia;
            player_2.Mensagem("Jogador2 : recebeu a bola");

            Singleton player_3 = Singleton.GetInstancia;
            player_3.Mensagem("Jogador3 : recebeu o lançamento");
        }
    }
}
