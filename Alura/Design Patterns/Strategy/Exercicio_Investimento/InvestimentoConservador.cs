namespace Strategy.Exercicio_Investimento
{
    public class InvestimentoConservador : TipoDeInvestimento
    {
        public decimal Calular(decimal valor)
        {
            return valor * 0.07M;               
        }
    }
}