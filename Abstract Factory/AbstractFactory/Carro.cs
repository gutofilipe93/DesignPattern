using AbstractFactory.Interface;

namespace AbstractFactory
{
    public class Carro
    {
        public IRoda Roda { get; set; }        
        public ISom Som { get; set; }
    }
}