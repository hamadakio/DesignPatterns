using System;

namespace Memento
{
    class Program
    {   //Captura e restaura o estado interno de um objeto
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";

            Caretaker caretaker = new Caretaker();
            caretaker.memento = originator.CreateMemento();

            originator.State = "Off";

            originator.SetMemento(caretaker.memento);
        }
    }
}
