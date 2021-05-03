namespace Strategy
{
    public class Soma : ICalculadora
    {
        public double Operacao(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}