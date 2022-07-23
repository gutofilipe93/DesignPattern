namespace Decorator
{
    public class Orcamento
    {
        public Orcamento(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; private set; }
        
    }
}