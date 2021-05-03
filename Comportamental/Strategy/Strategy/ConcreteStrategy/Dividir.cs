using System;

namespace Strategy
{
    public class Dividir : ICalculadora
    {
        public double Operacao(double n1, double n2)
        {
            if(n2 == 0)
                throw new InvalidOperationException();

            return n1/n2;    
        }
    }
}