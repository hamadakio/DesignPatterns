using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public abstract class Tartaruga
    {
        //caracteristicas intrinseca 
        protected string Condicao;
        protected string Acao;

        //caracteristica extrinseca
        public string Cor { get; set; }

        public abstract void Mostrar(string cor);
    }
}
