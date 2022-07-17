namespace Strategy.Exercicio_Investimento
{
    public class InvestimentoArrojado : TipoDeInvestimento
    {
        public decimal Calular(decimal valor)
        {
            bool escolhido = new Random().Next(101) > 30;
            if(escolhido)
                return valor * 0.006M;

            return valor * 0.038M;      
        }
    }
}