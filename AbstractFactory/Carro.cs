using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //classe concreta
    public class Carro
    {
        public Roda roda { get; set; }
        public Som som { get; set; }
    }
}
