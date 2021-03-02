namespace Chain_Of_Responsibility
{
    public class CustomerBudget
    {
        public bool Approved { get; set; } = false;
        public decimal Total { get; set; }

        public CustomerBudget(decimal total)
        {
            Total = total;
        }        
    }
}