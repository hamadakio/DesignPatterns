using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class FuncionarioPermanente : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }

        public IFuncionario Clone()
        {
            //faz uma copia deste objeto e converte para Ifuncionario
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}
