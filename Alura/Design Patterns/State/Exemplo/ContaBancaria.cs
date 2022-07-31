namespace State.Exemplo
{
    public class ContaBancaria
    {
        public double Valor { get; set; }
        public IStatusConta statusConta {get; set;}

        public void Sacar()
        {
            statusConta.Sacar(this);
        }

        public void Depositar()
        {
            statusConta.Depositar(this);
        }

        public void StatusPositivo()
        {
            statusConta.StatusPositivo(this);
        }

        public void StatusNegativo()
        {
            statusConta.StatusNegativo(this);
        }

    }
}