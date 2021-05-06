using System;

namespace Template_Method
{
    public class TreinoNoMeioDaTemporada : Treinos
    {
        public override void JogoTreino()
        {
            Console.WriteLine("Jogo treino com reserva");
        }

        public override void PreparoFisico()
        {
            Console.WriteLine("Preparo fisico intenso");            
        }
    }
}