using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Livro(string autor, string titulo , int numCopias)
        {
            Autor = autor;
            Titulo = titulo;
            NumCopias = numCopias;
        }

        public override void Exibir()
        {
            Console.WriteLine("\n Livro ----");
            Console.Write("Autor : {0}\n" +
                          "Titulo: {1}\n" +
                          "Numero de Copias: {2}\n",Autor,Titulo,NumCopias);
        }
    }
}
