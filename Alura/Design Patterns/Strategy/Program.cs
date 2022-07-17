// See https://aka.ms/new-console-template for more information

using Strategy;


var imposto = new ICCC();
var orcamento = new Orcamento(4000);

new CalculadorDeImposto().RealizarCalculo(orcamento,imposto);

