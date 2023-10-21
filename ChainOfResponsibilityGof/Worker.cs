namespace ChainOfResponsibilityGof
{
    public abstract class Worker
    {
        protected Worker _nextWorker;
        public void SetNextApprover(Worker worker)
        {
            _nextWorker = worker;
        }
        public abstract void Execute(Withdraw withdraw);
    }
}