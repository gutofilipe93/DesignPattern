// See https://aka.ms/new-console-template for more information

using Decorator;

// var imposto = new ISS(new ICCC(new ICMS()));
// var orcamento = new Orcamento(1000);
// var valor = imposto.Calcular(orcamento);

var imposto = new ImpostoMtoAlto(new ISS());
var orcamento = new Orcamento(1000);
var valor = imposto.Calcular(orcamento);
Console.WriteLine(valor);
