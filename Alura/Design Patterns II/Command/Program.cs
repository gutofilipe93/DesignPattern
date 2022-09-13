using Command;

Pedido pedido1 = new Pedido("Mauricio", 150.0);
Pedido pedido2 = new Pedido("Marcelo", 250.0);

FilaDeTrabalho fila = new FilaDeTrabalho();

fila.Adicionar(new PagaPedido(pedido1));
fila.Adicionar(new PagaPedido(pedido2));
fila.Adicionar(new FinalizaPedido(pedido1));

fila.Processar();