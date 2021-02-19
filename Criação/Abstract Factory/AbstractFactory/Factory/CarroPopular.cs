using AbstractFactory.Concreta;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class CarroPopular : CarroFactory
    {
        public override IRoda MontarRoda()
        {
            return new RodaSimples();
        }

        public override ISom MontarSom()
        {
            return new TocaFitas();
        }
    }
}