namespace DomainModel
{
    internal class DirectorCalculator : ICalculate
    {
        public decimal Calculate(decimal amount)
        {
            return amount * (decimal)1.15;
        }
    }
}
