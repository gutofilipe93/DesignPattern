using System;
using Observer.Usuarios;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var controladorEmail = new ControladorEmail();

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");

            var usuarioA = new UsuarioA(controladorEmail);
            var usuarioB = new UsuarioB(controladorEmail);
            var usuarioC = new UsuarioC(controladorEmail);

            Console.WriteLine("Enviando os emails para os usuários assinados (usuários cadastrados).\n");

            controladorEmail.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu cancelar a assinatura e não irá receber mais emails.\n");
            usuarioA.Dispose();

            Console.WriteLine("Enviando os emails para os usuários assinados.\n");
            controladorEmail.EnviarEmail();
        }
    }
}
