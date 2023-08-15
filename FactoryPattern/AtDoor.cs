namespace FactoryPattern
{
    public class AtDoor : IPayment
    {
        public void DoPayment()
        {
            Console.WriteLine("At door payment was done!");
        }

        public void DoSomeOtherJobs()
        {
            Console.WriteLine("At door other job was done!");
        }
    }
}
