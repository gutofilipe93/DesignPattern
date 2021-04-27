using System;

namespace State.Shopping_Order
{
    public class ShoppingOrder 
    {
        private IShoppingOrderState _state;
        public ShoppingOrder()
        {
            _state = new OrderPending(this);
        }

        public IShoppingOrderState GetState()
        {
            return _state;
        }

        public void SetState(IShoppingOrderState state)
        {
            _state = state;
            Console.WriteLine($"O estado do pedido agora é: {_state.GetName()}");
        }

        public string GetStateName()
        {
            return _state.GetName();
        } 

        public void RejectPayment()
        {
            _state.RejectPayment();
        }

        public void ShipOrder()
        {
            _state.ShipOrder();
        }

        public void WaitPayment()
        {
            _state.WaitPayment();
        }

        public void ApprovePayment()
        {
            _state.ApprovePayment();
        }
    }
}