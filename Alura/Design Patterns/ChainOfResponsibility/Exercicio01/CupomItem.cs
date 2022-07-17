namespace ChainOfResponsibility.Exercicio01
{
    public class CupomItem
    {
        public CupomItem(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
 
    }
}