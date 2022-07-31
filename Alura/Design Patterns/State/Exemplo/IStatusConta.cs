namespace State.Exemplo
{
    public interface IStatusConta
    {
        void Sacar(ContaBancaria contaBancaria);
        void Depositar(ContaBancaria contaBancaria);        
        void StatusPositivo(ContaBancaria contaBancaria);
        void StatusNegativo(ContaBancaria contaBancaria);
    }
}