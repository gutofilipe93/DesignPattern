namespace State.Exemplo
{
    public class ContaStatusNegativo : IStatusConta
    {
        public void Depositar(ContaBancaria contaBancaria)
        {
            contaBancaria.Valor = contaBancaria.Valor * 0.95;
        }

        public void Sacar(ContaBancaria contaBancaria)
        {
            throw new AggregateException("Conta com status negativo não aceita saques");
        }

        public void StatusPositivo(ContaBancaria contaBancaria)
        {
            contaBancaria.statusConta = new ContaStatusPositivo();
        }

        void IStatusConta.StatusNegativo(ContaBancaria contaBancaria)
        {
            throw new AggregateException("Conta já esta em status negativo");
        }
    }
}