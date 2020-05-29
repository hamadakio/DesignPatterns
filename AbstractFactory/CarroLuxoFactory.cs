using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //classe de fabricaçao concreta , herda de uma classe abstrata e implementa os metodos

    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som montarSom()
        {
            return new SomBtPlayer();
        }
    }
}
