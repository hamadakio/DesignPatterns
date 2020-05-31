using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Componente
    {
        protected string Nome;

        protected Componente(string nome)
        {
            Nome = nome;
        }

        public abstract void Add(Componente c);

        public abstract void Remover(Componente c);

        public abstract void Mostrar(int profundidade);

    }
}
