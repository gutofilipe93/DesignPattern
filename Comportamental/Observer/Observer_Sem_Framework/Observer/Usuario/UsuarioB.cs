using System;

namespace Observer.Usuario
{
    public class UsuarioB : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email recebido pelo usuário B");
        }
    }
}