namespace DomainModel
{
    internal class NormalWorkerCalculator : ICalculate
    {
        public decimal Calculate(decimal amount)
        {
            return amount * (decimal)0.75;
        }
    }
}
