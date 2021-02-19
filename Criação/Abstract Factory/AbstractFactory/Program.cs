using System;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = MontarCarro("luxo");
            Carro c2 = MontarCarro("popular");

            // Da forma que foi feito esta facil caso precise adiconar um novo tipo de carro            
        }

        public static Carro MontarCarro(string tipo){
            CarroFactory cf = null;
            switch (tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;    
                case "popular":
                    cf = new CarroPopular();
                    break;
                default:
                    break;
            }
            Carro carro = new Carro();
            carro.Roda = cf.MontarRoda();
            carro.Som = cf.MontarSom();
            return carro;
        } 
    }
}
