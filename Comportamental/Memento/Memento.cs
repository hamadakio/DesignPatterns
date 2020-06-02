using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        private string _State;

        public Memento(string state)
        {
            _State = state;
        }

        public string State
        {
            get { return _State; }
        }

    }
}
