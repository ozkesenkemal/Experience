namespace ChainOfResponsibilityGof
{
    public class AsistantGeneralManager : Worker
    {
        public override void Execute(Withdraw withdraw)
        {
            if(withdraw._amount < 5000)
            {
                Console.WriteLine($"{withdraw._customerId} {withdraw._amount} {withdraw._currency} 'yi GMY verebilir.");
            }
            else
            {
                if (_nextWorker != null)
                {
                    Console.WriteLine("GMY yetkisi dışında. Sıradaki Yöneticiye gidiyoruz.");
                    _nextWorker.Execute(withdraw);
                }
            }
        }
    }
}
