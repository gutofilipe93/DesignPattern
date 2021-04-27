namespace State.Shopping_Order
{
    public interface IShoppingOrderState
    {
        string GetName();
        void ApprovePayment();
        void RejectPayment();
        void WaitPayment();
        void ShipOrder();
    }
}