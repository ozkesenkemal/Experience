namespace DomainModel
{
    public class CalculateManager
    {
        private ICalculate _calculator;

        public decimal CalculateSummary(DomainModelWorker domainModelWorker)
        {
            if(domainModelWorker.IsDirector)
            {
                _calculator = new DirectorCalculator();
            }
            else
            {
                _calculator = new NormalWorkerCalculator();
            }

            return _calculator.Calculate(domainModelWorker.Salary);
        }
    }
}