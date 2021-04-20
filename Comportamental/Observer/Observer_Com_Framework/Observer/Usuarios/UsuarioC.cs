using System;

namespace Observer.Usuarios
{
    public class UsuarioC : IObserver<string>
    {
        private IDisposable _disposer;

        public UsuarioC(IObservable<string> controladorEmail)
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
            Console.WriteLine(value + "C");
        }

        public void Dispose()
        {
            _disposer.Dispose();
        }
    }
}