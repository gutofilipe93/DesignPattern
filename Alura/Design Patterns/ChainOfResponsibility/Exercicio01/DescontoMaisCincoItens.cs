namespace ChainOfResponsibility.Exercicio01
{
    public class DescontoMaisCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal TotalDesconto(Cupom cupom)
        {
            if(cupom.Items.Count() <= 5) return Proximo.TotalDesconto(cupom);

            return cupom.GetTotal() * 0.1M;
        }
    }
}