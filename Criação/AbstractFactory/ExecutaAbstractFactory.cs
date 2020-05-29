using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montaCarro(string tipo)
        {
            CarroFactory cf = null;

            switch (tipo)
            {
                case "Luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "Popular":
                    cf = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            carro.roda = cf.montarRoda();
            carro.som = cf.montarSom();

            return carro;
        }
    }
}
