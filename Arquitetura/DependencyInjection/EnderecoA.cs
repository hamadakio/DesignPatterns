using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class EnderecoA : IObjetoEndereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}
