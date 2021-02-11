using AbstractFactory.Concreta;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new CDPlayer();
        }
    }
}