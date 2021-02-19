using AbstractFactory.Interface;

namespace AbstractFactory.Factory
{
    public abstract class CarroFactory
    {
        public abstract IRoda MontarRoda ();
        public abstract ISom MontarSom();
    }
}