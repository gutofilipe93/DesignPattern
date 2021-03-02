using System;

namespace Chain_Of_Responsibility
{
    public class ManagerBudgetHandler : BaseBudgetHandler
    {
         public override CustomerBudget Handler(CustomerBudget budget)
        {
            if(budget.Total <= 5000 )
            {
                Console.WriteLine("O gerente tratou o orçamento");
                budget.Approved = true;
                return budget;
            } 
            return nextHandler.Handler(budget); 
        }
    }
}