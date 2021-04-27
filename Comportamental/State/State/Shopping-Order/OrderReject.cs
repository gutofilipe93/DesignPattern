using System;

namespace State.Shopping_Order
{
    public class OrderReject : IShoppingOrderState
    {
        private string _name = "OrderReject";
        private ShoppingOrder _order;
        public OrderReject(ShoppingOrder order)
        {
            _order = order;
        }
        public void ApprovePayment()
        {
            Console.WriteLine("Não posso aprovar pagamento pois o pedido foi recusado.");
        }

        public string GetName()
        {
            return _name;
        }

        public void RejectPayment()
        {
            Console.WriteLine("O pedid já esta recusado.");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Não posso enviar um pedido com pagamento recusado");
        }

        public void WaitPayment()
        {
            Console.WriteLine("Não posso mover para pendente porque o pedido foi recusado");
        }
    }
}