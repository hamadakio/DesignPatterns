using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        //responsavel por instanciar os objetos dinamicamente
        //ou seja , em tempo de execuçao sera decidido qual objeto sera "fabricado"

        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "LiuKang": return new LiuKang();
                case "Scorpion": return new Scorpion();
                case "SubZero": return new SubZero();

                default: return null;
                    break;
            }
        }
    }
}