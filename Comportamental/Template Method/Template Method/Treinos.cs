using System;

namespace Template_Method
{
    public abstract class Treinos
    {

        public void treinoDiario()
        {
            PreparoFisico();
            JogoTreino();
            TreinoTatico();
        }

        public abstract void PreparoFisico();
        public abstract void JogoTreino();

        private void TreinoTatico()
        {
            Console.WriteLine("Treino Tático");
        }
    }
}