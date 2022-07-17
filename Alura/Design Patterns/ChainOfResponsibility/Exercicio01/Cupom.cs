namespace ChainOfResponsibility.Exercicio01
{
    public class Cupom
    {
        public Cupom()
        {
            Items = new List<CupomItem>();
        }

        public List<CupomItem> Items { get; set; }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.Preco);
        }
    }
}