using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Empresa 
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        //acoplamento
        public IObjetoEndereco Endereco { get; set; }

        ////atraves de interface
        //public void setEndereco(IObjetoEndereco obj)
        //{
        //    Endereco = obj;
        //}

        ////atraves de get e set
        //public IObjetoEndereco _Endereco 
        //{
        //    //retorna o valor privado
        //    get { return Endereco; }

        //    set { _Endereco = value; }
        //}

        //atraves do Construtor
        public Empresa(IObjetoEndereco endereco)
        {
            Endereco = endereco;

           ///Atraves de outra classe = service locator
           // Endereco = Localizador.getEndereco();
        }
    }
}
