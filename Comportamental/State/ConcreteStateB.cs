namespace State
{
    internal class ConcreteStateB : State
    {
        public ConcreteStateB()
        {
        }

        public override void Handle(Context context)
        {
            context.State = new ConcreteState();
        }
    }
}