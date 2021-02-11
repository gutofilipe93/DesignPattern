using AbstractFactory.Concreta;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class CarroPopular : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new TocaFitas();
        }
    }
}