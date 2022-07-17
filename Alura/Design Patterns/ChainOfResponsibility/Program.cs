
using ChainOfResponsibility.Exercicio01;
using ChainOfResponsibility.Exercicio02;

Cupom cupom = new Cupom();
cupom.Items.Add(new CupomItem ("LAPIS",100m)) ;
cupom.Items.Add(new CupomItem ("CANETA",100m)) ;


IDesconto descontoMaisCincoItens = new DescontoMaisCincoItens();
IDesconto descontoValorMaior500 = new DescontoValorMaior500();
IDesconto descontoPorVendaCasada = new DescontoPorVendaCasada();
IDesconto semDesconto = new SemDesconto();

descontoMaisCincoItens.Proximo = descontoValorMaior500;
descontoValorMaior500.Proximo = descontoPorVendaCasada;
descontoPorVendaCasada.Proximo = semDesconto;

Console.WriteLine(descontoMaisCincoItens.TotalDesconto(cupom));
Console.ReadKey();
