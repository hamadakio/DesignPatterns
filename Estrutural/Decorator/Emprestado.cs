using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //Decorador concreto

    public class Emprestado : Decorator
    {
        protected List<string> Emprestados = new List<string>();

        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
        }

        
        public void EmprestarItem(string nome)
        {
            Emprestados.Add(nome);
            ItemBiblioteca.NumCopias--;
        }

        public void DevolverItem(string nome)
        {
            Emprestados.Remove(nome);
            ItemBiblioteca.NumCopias++;
        }

        public override void Exibir()
        {
            base.Exibir();
            foreach (string item in Emprestados)
            {
                Console.WriteLine("\nEmprestado para :{0}" , item);
            }
        }
    }
}
