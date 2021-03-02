using System;

namespace Chain_Of_Responsibility
{
    public class CEOBudgetHandler : BaseBudgetHandler
    {
        public override CustomerBudget Handler(CustomerBudget budget)
        {
            Console.WriteLine("O CEO tratou o orçamento");
            budget.Approved = true;
            return budget;
        }
    }
}