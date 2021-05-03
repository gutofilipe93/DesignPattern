using System;

namespace Strategy
{
    public class Calcular
    {
        public ICalculadora Calculadora { get; set; }
        public void Operacao(double n1, double n2)
        {
            Console.WriteLine(Calculadora.Operacao(n1,n2));
        }
    }
}