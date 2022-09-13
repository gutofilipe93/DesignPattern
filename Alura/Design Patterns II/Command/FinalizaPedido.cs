namespace Command
{
    public class FinalizaPedido : IComando
    {
        private Pedido _pedido;

        public FinalizaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Finalizar();
            Console.WriteLine($"Pedido do cliente: {_pedido.Cliente} foi finalizado");
        }
    }
}