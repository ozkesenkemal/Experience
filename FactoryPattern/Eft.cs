namespace FactoryPattern
{
    public class Eft : IPayment
    {
        public void DoPayment()
        {
            Console.WriteLine("Eft payment was done!");
        }
    }
}
