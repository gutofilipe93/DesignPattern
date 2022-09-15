using Adapter;

Cliente cliente = new Cliente();
cliente.Nome = "victor";
cliente.Endereco = "Rua Vergueiro";
cliente.DataNascimento = DateTime.Now;

GeradorDeXml gerador = new GeradorDeXml();
String xml = gerador.Gerar(cliente);