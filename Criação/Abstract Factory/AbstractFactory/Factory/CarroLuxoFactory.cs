using AbstractFactory.Concreta;
using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override IRoda MontarRoda()
        {
            return new RodaLigaLeve();
        }

        public override ISom MontarSom()
        {
            return new CDPlayer();
        }
    }
}