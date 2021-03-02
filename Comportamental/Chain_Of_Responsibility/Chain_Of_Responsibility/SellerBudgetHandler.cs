using System;

namespace Chain_Of_Responsibility
{
    public class SellerBudgetHandler : BaseBudgetHandler
    {        
        public override CustomerBudget Handler(CustomerBudget budget)
        {
            if(budget.Total <= 1000 )
            {
                Console.WriteLine("O vendedor tratou o orçamento");
                budget.Approved = true;
                return budget;
            } 
            return nextHandler.Handler(budget); 
        }
    }
}