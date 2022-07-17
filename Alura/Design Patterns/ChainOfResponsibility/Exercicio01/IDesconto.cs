namespace ChainOfResponsibility.Exercicio01
{
    public interface IDesconto
    {
        decimal TotalDesconto(Cupom cupom);
        IDesconto Proximo{get; set;}
    }
}