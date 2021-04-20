namespace Observer
{
    public interface ISubject
    {
         void Registar(IObserver observer);
         void Remover(IObserver observer);
         void EnviarEmail();
    }
}