using System;

namespace Builder
{
    class Program
    {
        //classe concreta é que a implementa as abstratas
        static void Main(string[] args)
        {
            //cria o fabricante
            Fabricante fabricante = new Fabricante();

            //permite que a classe Builder esteja pronta
            ICelular celularBuilder = null;

            //cria um celular Android
            celularBuilder = new IphoneBuilder();
            fabricante.Contrutor(celularBuilder);
            Console.WriteLine("Um novo celular foi construido : \n\n{0}" , celularBuilder.Celular.Nome.ToString());
        }
    }
}
