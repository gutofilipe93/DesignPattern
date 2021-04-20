using System;

namespace Observer.Usuario
{
    public class UsuarioA : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email recebido pelo usuário A");
        }
    }
}