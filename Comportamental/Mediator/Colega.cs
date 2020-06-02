namespace Mediator
{
    public abstract class Colega
    {
        protected Mediador mediador;

        protected Colega(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}