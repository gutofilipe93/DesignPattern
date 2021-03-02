using System;

namespace Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerBudget = new CustomerBudget(50000);

            var seller = new SellerBudgetHandler();
            seller.SetNextHandler(new ManagerBudgetHandler())
                    .SetNextHandler(new DirectorBudgetHandler())
                    .SetNextHandler(new CEOBudgetHandler());

            seller.Handler(customerBudget);                    
        }
    }
}
