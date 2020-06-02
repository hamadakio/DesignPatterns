using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ObservadorConcreto : Observador
    {
        private string Nome;
        private string Estado;
        private AssuntoConcreto assunto;

        public ObservadorConcreto(string nome, AssuntoConcreto assunto)
        {
            Nome = nome;
            this.assunto = assunto;
        }

        public override void Update()
        {
            Estado = assunto.EstadoAssunto;
            Console.WriteLine("Observador {0} , seu novo estado é :{1}" , Nome , Estado);
        }

        public AssuntoConcreto Assunto { get; set; }

    }
}
