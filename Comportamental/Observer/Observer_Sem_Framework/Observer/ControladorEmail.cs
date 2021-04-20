using System.Collections.Generic;

namespace Observer
{
    public class ControladorEmail : ISubject
    {
        private readonly List<IObserver> _usuarios;
        public ControladorEmail()
        {
            _usuarios = new List<IObserver>();
        }

        public void EnviarEmail()
        {
            foreach (var usuario in _usuarios)
                usuario.ReceberEmail();

        }

        public void Registar(IObserver observer)
        {
            _usuarios.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            _usuarios.Remove(observer);
        }
    }
}