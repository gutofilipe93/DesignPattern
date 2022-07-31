namespace Builder
{
    public class ItemDaNota
    {
        public ItemDaNota(string name, double valor)
        {
            Valor = valor;
            Name = name;
        }

        public double Valor { get; private set; }
        public string Name { get; private set; }
    }
}