// See https://aka.ms/new-console-template for more information


using Builder;

NotaFiscal nf = new NotaFiscalBuilder().SetRazaoSocial("Caelum")
                          .SetCnpj("123.456.789/0001-10")
                          .SetIemDaNota(new ItemDaNota("item 1", 100.0))
                          .SetIemDaNota(new ItemDaNota("item 2", 200.0))
                          .SetIemDaNota(new ItemDaNota("item 3", 300.0))
                          .SetObservacao("entregar nf pessoalmente")                          
                          .Builder();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);
