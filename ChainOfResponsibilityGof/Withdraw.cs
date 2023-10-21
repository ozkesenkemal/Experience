namespace ChainOfResponsibilityGof
{
    public class Withdraw
    {
        public string _customerId { get; }
        public decimal _amount { get; }
        public string _currency { get; }
        public Withdraw(string customerId, decimal amount, string currency)
        {
            _customerId = customerId;
            _amount = amount;
            _currency = currency;
        }
    }
}
