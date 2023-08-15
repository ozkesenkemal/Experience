namespace FactoryPattern
{
    public class Eft : IPayment
    {
        public void DoPayment()
        {
            Console.WriteLine("Eft payment was done!");
        }
        public void DoSomeOtherJobs()
        {
            Console.WriteLine("Eft other job was done!");
        }
    }
}
