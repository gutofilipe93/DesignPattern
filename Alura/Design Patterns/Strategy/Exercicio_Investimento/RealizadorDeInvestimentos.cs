namespace Strategy.Exercicio_Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Calcular(ContaTitular contaTitular, TipoDeInvestimento tipoDeInvestimento)
        {
            var saldoConta = tipoDeInvestimento.Calular(contaTitular.SaldoConta);
        }
    }
}