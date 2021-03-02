using System;

namespace Chain_Of_Responsibility
{
    public class DirectorBudgetHandler : BaseBudgetHandler
    {
        public override CustomerBudget Handler(CustomerBudget budget)
        {
            if (budget.Total <= 10000)
            {
                Console.WriteLine("O diretor tratou o orçamento");
                budget.Approved = true;
                return budget;
            }
            return nextHandler.Handler(budget);
        }
    }
}