using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarroPopularFactory : CarroFactory
    {
        //classe de fabricaçao concreta , herda de uma classe abstrata e implementa os metodos

        public override Roda montarRoda()
        {
            return new RodaSimples();
        }

        public override Som montarSom()
        {
            return new SomCDPlayer();
        }
    }
}
