using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public abstract class CarroFactory
    {
        public abstract Roda MontarRoda ();
        public abstract Som MontarSom();
    }
}