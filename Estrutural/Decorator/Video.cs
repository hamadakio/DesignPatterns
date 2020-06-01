using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Video(string diretor, string titulo, int duracao, int numCopias)
        {
            Diretor = diretor;
            Titulo = titulo;
            Duracao = duracao;
            NumCopias = numCopias;
        }

        public override void Exibir()
        {
            Console.WriteLine("\n Video ----");
            Console.Write("Diretor : {0}" +
                          "\nTitulo: {1}" +
                          "\nDuração: {2}" +
                          "\nNumero de Copias: {3}\n", Diretor, Titulo,Duracao, NumCopias);
        }
    }
}
