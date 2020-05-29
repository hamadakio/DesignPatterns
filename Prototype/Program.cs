using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcionarioPermanente = new FuncionarioPermanente();
            funcionarioPermanente.Nome = "Joao";
            funcionarioPermanente.Idade = 30;
            funcionarioPermanente.Tipo = "Permanente";

            FuncionarioPermanente funcionarioPermanente_clone = (FuncionarioPermanente)funcionarioPermanente.Clone();
            funcionarioPermanente_clone.Nome = "Carlos";
            funcionarioPermanente_clone.Idade = 40;

            Console.WriteLine("Detalha funcionario permanente");
            Console.WriteLine("Nome: {0}; \nIdade:{1} ; \nTipo:{2}\n\n", funcionarioPermanente.Nome,
                funcionarioPermanente.Idade,funcionarioPermanente.Tipo);

            Console.WriteLine("Detalha funcionario permanente Clonado");
            Console.WriteLine("Nome: {0}; \nIdade:{1} ; \nTipo:{2}", funcionarioPermanente_clone.Nome,
                funcionarioPermanente_clone.Idade, funcionarioPermanente_clone.Tipo);

        }
    }
}
