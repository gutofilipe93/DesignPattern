namespace Strategy.Exercicio_Investimento
{
    public class InvestimentoModerado : TipoDeInvestimento
    {
        public decimal Calular(decimal valor)
        {
            return valor * 0.016M;
        }
    }
}