namespace ChainOfResponsibility.Exercicio01
{
    public class DescontoValorMaior500 : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal TotalDesconto(Cupom cupom)
        {
            if(cupom.GetTotal() <= 500) return Proximo.TotalDesconto(cupom);

            return cupom.GetTotal() * 0.07M;
        }
    }
}