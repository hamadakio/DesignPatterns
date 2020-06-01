using System;

namespace Decorator
{
    class Program
    {
        //anexa responsabilidade dinamica a um objeto

        static void Main(string[] args)
        {

            Livro livro = new Livro("Pseudonimo","Quem Sou Eu?",15);
            livro.Exibir();

            Video video = new Video("SemDirecao","NoControle",120,12);
            video.Exibir();

            Console.WriteLine("\nEmprestando um Video...");

            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Cliente1");
            emprestado.EmprestarItem("Cliente2");


            emprestado.Exibir();

            Console.WriteLine("\nDevolvendo Video...");
            emprestado.DevolverItem("Cliente1");

            emprestado.Exibir();

        }
    }
}
