using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SmartTV
    {
        public ICanal canal_atual { get; set; }

        public void ExibeCanal()
        {
            if (canal_atual != null)
            {
                Console.WriteLine(canal_atual.Canal());
            }
            else
            {
                Console.WriteLine("Por favor , selecione um canal");
            }
        }

        public void PlayTV()
        {
            if (canal_atual != null)
            {
                Console.WriteLine(canal_atual.Status());
            }
            else
            {
                Console.WriteLine("Por favor , selecione um canal");
            }
        }
    }
}
