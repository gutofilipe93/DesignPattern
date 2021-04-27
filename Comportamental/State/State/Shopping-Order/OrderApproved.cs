using System;

namespace State.Shopping_Order
{
    public class OrderApproved : IShoppingOrderState
    {
         private string _name = "OrderApproved";
        private ShoppingOrder _order;
        public OrderApproved(ShoppingOrder order)
        {
            _order = order;
        }
        public void ApprovePayment()
        {
            Console.WriteLine("O pedido já foi aprovado");
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
            Console.WriteLine("Enviando pedido para o cliente...");
        }

        public void WaitPayment()
        {
            _order.SetState(new OrderPending(_order));
        }
    }
}