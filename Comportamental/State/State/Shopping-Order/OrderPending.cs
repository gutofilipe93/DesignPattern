using System;

namespace State.Shopping_Order
{
    public class OrderPending : IShoppingOrderState
    {
        private string _name = "OrderPending";
        private ShoppingOrder _order;
        public OrderPending(ShoppingOrder order)
        {
            _order = order;
        }

        public void ApprovePayment()
        {
            _order.SetState(new OrderApproved(_order));
        }

        public string GetName()
        {
            return _name;
        }

        public void RejectPayment()
        {
            _order.SetState(new OrderReject(_order));
        }

        public void ShipOrder()
        {
            Console.WriteLine("Não posso enviar pedido com pagamento pendente");
        }

        public void WaitPayment()
        {
            Console.WriteLine("O pedido já esta no estado pagamento pendente");
        }
    }
}