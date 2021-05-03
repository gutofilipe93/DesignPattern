using System;

namespace Strategy
{
    public class Subtrair : ICalculadora
    {
        public double Operacao(double n1, double n2)
        {
            if(n2 > n1)
                throw new InvalidOperationException();

            return n1 - n2;
        }        
    }
}