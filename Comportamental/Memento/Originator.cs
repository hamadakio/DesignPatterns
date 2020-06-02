using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Originator
    {
        private string _State;

        public string State
        {
            get { return _State; }
            set { _State = value;
                Console.WriteLine("State = {0}",_State);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_State);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o estado....");
            State = memento.State;
        }
    }
}
