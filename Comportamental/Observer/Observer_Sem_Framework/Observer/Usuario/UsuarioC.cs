using System;

namespace Observer.Usuario
{
    public class UsuarioC : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email recebido pelo usuário C");
        }
    }
}