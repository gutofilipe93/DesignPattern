namespace Builder
{
    public class ItemDaNotaBuilder
    {
        public string Name { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder SetNome(string nome)
        {
            this.Name = nome;
            return this;
        }

        public ItemDaNotaBuilder SetValor(double Valor)
        {
            this.Valor = Valor;
            return this;
        }

        public ItemDaNota Builder()
        {
            return new ItemDaNota(this.Name,this.Valor);
        }
    }
}