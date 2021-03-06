using System;

namespace Observer.Usuarios
{
    public class UsuarioB : IObserver<string>
    {
        private IDisposable _disposer;
        public UsuarioB(IObservable<string> controladorEmail)
        {
            _disposer = controladorEmail.Subscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(string value)
        {
            Console.WriteLine(value + "B");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}