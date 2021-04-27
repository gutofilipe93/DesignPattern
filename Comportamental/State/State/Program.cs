using System;
using State.Shopping_Order;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new ShoppingOrder(); // Pendente
            order.ApprovePayment(); // Aprovado
            order.WaitPayment(); // Pendente
            order.ShipOrder(); 

            order.RejectPayment(); // Daqui não altera mais o estado
            order.ApprovePayment();
            order.WaitPayment();
            order.ApprovePayment();
            order.ShipOrder();
        }
    }
}
