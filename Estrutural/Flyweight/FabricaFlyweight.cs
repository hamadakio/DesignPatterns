using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga>
            Lista_Tartarugas = new Dictionary<string, Tartaruga>(); 

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;
            // se ja tiver um objeto alocado na memoria ele so é reaproveitado
            if (Lista_Tartarugas.ContainsKey(cor))
            {
                tartaruga = Lista_Tartarugas[cor];
            }//senao o objeto nao existe e sera instanciado e alocado
            else
            {
                switch (cor)
                {
                    case "azul":
                        tartaruga = new Azul();
                        break;
                    case "laranja":
                        tartaruga = new Laranja();
                        break;
                    case "vermelha":
                        tartaruga = new Vermelha();
                        break;
                }

                Lista_Tartarugas.Add(cor,tartaruga);
            }

            return tartaruga;
        }

    }
}
