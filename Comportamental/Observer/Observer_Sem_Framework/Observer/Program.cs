using System;
using Observer.Usuario;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject controlaEmail = new ControladorEmail();

            var usuarioA = new UsuarioA();
            var usuarioB = new UsuarioB();
            var usuarioC = new UsuarioC();

            controlaEmail.Registar(usuarioA);
            controlaEmail.Registar(usuarioB);
            controlaEmail.Registar(usuarioC);

            Console.WriteLine("Os usuários A, B, C cadastraram-se para receber as promoções \n");
            Console.WriteLine("Enviando email para os usuários assinados (usuarios cadastrados) \n");
            
            controlaEmail.EnviarEmail();

            Console.WriteLine("UsuárioA resolveu cancelar a assinatura e não irá mais receber os emails \n");
            controlaEmail.Remover(usuarioA);

            Console.WriteLine("Enviando os emails para os usuarios assinados.\n");
            controlaEmail.EnviarEmail();
            
        }
    }
}
