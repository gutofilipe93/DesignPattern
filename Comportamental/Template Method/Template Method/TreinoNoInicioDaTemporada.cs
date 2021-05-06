using System;

namespace Template_Method
{
    public class TreinoNoInicioDaTemporada : Treinos
    {
        public override void JogoTreino()
        {
            Console.WriteLine("Jogo treino com equipe Junior");
        }

        public override void PreparoFisico()
        {
            Console.WriteLine("Preparo fisico leve");
        }
    }
}