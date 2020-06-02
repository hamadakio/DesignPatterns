using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA enderecoA = new EnderecoA();
            enderecoA.Rua = "Rua A";
            enderecoA.Numero = 4;

            EnderecoB enderecoB = new EnderecoB();
            enderecoB.Cidade = "Sorocaba";
            enderecoB.UF = "SP";

            //empresa recebe uma interface do mesmo endereço 
            //o que permite inserir endercos diferentes que herdam da mesma interface
            //a injecao de dependencia nesse caso foi feito no construtor
            ////Empresa empresa1 = new Empresa(enderecoA);
            ////Empresa empresa2 = new Empresa(enderecoB);

        }
    }
}
