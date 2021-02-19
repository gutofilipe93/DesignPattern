namespace Prototype
{
    public sealed class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }


        public Carro ShallowCopy()
        {
            return (Carro) this.MemberwiseClone();
        }

  
        public Carro DeepCopy()
        {
            return new Carro 
            {
                Modelo = string.Copy(this.Modelo),
                Ano = string.Copy(this.Ano),
                Marca = string.Copy(this.Marca)
            };
        }
    }
}