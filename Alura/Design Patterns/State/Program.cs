// See https://aka.ms/new-console-template for more information
using State;

Orcamento reforma = new Orcamento(500.0m);


reforma.AplicarDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
reforma.AplicarDescontoExtra();
Console.WriteLine(reforma.Valor);
reforma.Aprova(); // aprova nota!

reforma.AplicarDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%
reforma.AplicarDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

reforma.Finaliza();