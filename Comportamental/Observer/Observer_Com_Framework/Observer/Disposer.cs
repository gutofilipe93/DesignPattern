using System;
using System.Collections.Generic;

namespace Observer
{
    public class Disposer : IDisposable
    {
        private List<IObserver<string>> _usuarios;
        private IObserver<string> _usuario;

        public Disposer(List<IObserver<string>> usuarios, IObserver<string> usuario)
        {
            _usuarios = usuarios;
            _usuario = usuario;
        }

        public void Dispose()
        {
            if(_usuarios.Contains(_usuario))
                _usuarios.Remove(_usuario);
        }
    }
}