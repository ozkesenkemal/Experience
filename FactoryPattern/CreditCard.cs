namespace FactoryPattern
{
    public class CreditCard : IPayment
    {
        public void DoPayment()
        {
            Console.WriteLine("Credit card payment was done!");
        }

        public void DoSomeOtherJobs()
        {
            Console.WriteLine("Credit card other job was done!");
        }
    }
}
