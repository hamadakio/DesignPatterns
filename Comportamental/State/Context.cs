using System;

namespace State
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set { state = value;
                Console.WriteLine("Estado : {0}",state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}