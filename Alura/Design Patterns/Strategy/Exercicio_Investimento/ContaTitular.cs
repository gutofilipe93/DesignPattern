namespace Strategy.Exercicio_Investimento
{
    public class ContaTitular
    {
        public decimal SaldoConta { get; set; }
        public ContaTitular(decimal saldoConta)
        {
            SaldoConta = saldoConta * 0.75M;
        }
                
    }
}