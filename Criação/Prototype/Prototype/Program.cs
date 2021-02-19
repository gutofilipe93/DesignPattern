using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro{ Ano = "2001", Marca = "Fiat", Modelo = "Uno"};
            /* Quando você atribui um objeto para outro qualquer alteração vai se refletir nos dois pq ambos tem o mesmo ponteiro */
            var car2 = car1;            

            /* Quando de faz uma copia de um objeto e esse objeto sofre alteração essas alterações não é refletida para copia e nem ao contrário*/
            var car3 = car1.ShallowCopy();
            var car4 = car1.DeepCopy();
            
            car2.Ano = "2015";
            car3.Modelo = "Gol";  
            car4.Marca = "Audi";
            

            Console.WriteLine($"{car1.Modelo} | {car1.Marca} | {car1.Ano}");

            Console.WriteLine("-----------------");          

            Console.WriteLine($"{car2.Modelo} | {car2.Marca} | {car2.Ano}");

            Console.WriteLine("-----------------");

            Console.WriteLine($"{car3.Modelo} | {car3.Marca} | {car3.Ano}");

            Console.WriteLine("-----------------");

            Console.WriteLine($"{car4.Modelo} | {car4.Marca} | {car4.Ano}");
        }
    }
}
