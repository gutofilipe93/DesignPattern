namespace ChainOfResponsibility.Exercicio01
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal TotalDesconto(Cupom cupom)
        {
            return 0;
        }
    }
}