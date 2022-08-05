using Observer;

NotaFiscal nf = new NotaFiscalBuilder().SetRazaoSocial("Caelum")
                          .SetCnpj("123.456.789/0001-10")
                          .SetIemDaNota(new ItemDaNota("item 1", 100.0))
                          .SetIemDaNota(new ItemDaNota("item 2", 200.0))
                          .SetIemDaNota(new ItemDaNota("item 3", 300.0))
                          .SetObservacao("entregar nf pessoalmente")                          
                          .SetAcaoAposGerarNota(new EnviadorDeEmail())                          
                          .SetAcaoAposGerarNota(new NotaFiscalDao()) 
                          .SetAcaoAposGerarNota(new Multiplicador(2))                          
                          .Builder();