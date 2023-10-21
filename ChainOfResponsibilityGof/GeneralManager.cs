namespace ChainOfResponsibilityGof
{
    public class GeneralManager : Worker
    {
        public override void Execute(Withdraw withdraw)
        {
            if(withdraw._amount < 75000)
            {
                Console.WriteLine($"{withdraw._customerId} {withdraw._amount} {withdraw._currency} 'yi Genel Müdür verebilir.");
            }
            else
            {
                Console.WriteLine("Bundan fazla para verilemez.");
            }
        }
    }
}
