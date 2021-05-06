using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Treinos treinos = new TreinoNoInicioDaTemporada();
            treinos.treinoDiario();

            treinos = new TreinoNoMeioDaTemporada();
            treinos.treinoDiario();
        }
    }
}
