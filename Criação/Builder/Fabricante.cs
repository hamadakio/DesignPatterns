using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Fabricante
    {
        public void Contrutor(ICelular celularBuilder)
        {
            celularBuilder.Nome();
            celularBuilder.BuildBateria();
            celularBuilder.BuildCamera();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
        }
    }
}
