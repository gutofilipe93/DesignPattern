namespace Chain_Of_Responsibility
{
    public abstract class BaseBudgetHandler
    {
        protected BaseBudgetHandler nextHandler = null;

        public BaseBudgetHandler SetNextHandler(BaseBudgetHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public virtual CustomerBudget Handler(CustomerBudget budget)
        {
            if(nextHandler != null)
                return nextHandler.Handler(budget);

            return budget;    
        }
    }
}