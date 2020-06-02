using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class EnderecoB : IObjetoEndereco
    {
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
