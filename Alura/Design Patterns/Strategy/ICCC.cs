namespace Strategy
{
    public class ICCC : Imposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * ProcessarValorImposto(orcamento);
        }

        private decimal ProcessarValorImposto(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return 0.05M;
            else if (orcamento.Valor <= 3000 && orcamento.Valor >= 1000)
                return 0.07M;

            return 0.08M + 30;
        }
    }
}