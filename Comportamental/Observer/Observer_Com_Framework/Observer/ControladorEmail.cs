using System;
using System.Collections.Generic;

namespace Observer
{
    public class ControladorEmail : IObservable<string>
    {
        public List<IObserver<string>> _usuarios;

        public ControladorEmail()
        {
            _usuarios = new List<IObserver<string>>();
        }

        public IDisposable Subscribe(IObserver<string> usuario)
        {
            if(!_usuarios.Contains(usuario))
                _usuarios.Add(usuario);

            return new Disposer(_usuarios,usuario);
        }

        public void EnviarEmail()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.OnNext("Email enviado para usuário");
            }
        }
    }
}