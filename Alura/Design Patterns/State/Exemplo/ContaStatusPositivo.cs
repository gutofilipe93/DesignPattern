namespace State.Exemplo
{
    public class ContaStatusPositivo : IStatusConta
    {
        public void StatusNegativo(ContaBancaria contaBancaria)
        {
            contaBancaria.statusConta = new ContaStatusNegativo();
        }

        public void Depositar(ContaBancaria contaBancaria)
        {
            contaBancaria.Valor = contaBancaria.Valor * 0.98;
        }

        public void Sacar(ContaBancaria contaBancaria)
        {
            contaBancaria.Valor -= contaBancaria.Valor;
        }

        public void StatusPositivo(ContaBancaria contaBancaria)
        {
            throw new AggregateException("Conta já esta em status positivo");
        }
    }
}