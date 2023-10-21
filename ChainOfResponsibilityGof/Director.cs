namespace ChainOfResponsibilityGof
{
    public class Director : Worker
    {
        public override void Execute(Withdraw withdraw)
        {
            if(withdraw._amount < 1000)
            {
                Console.WriteLine($"{withdraw._customerId} {withdraw._amount} {withdraw._currency} 'yi Director verebilir.");
            }
            else
            {
                if (_nextWorker != null)
                {
                    Console.WriteLine("Direktörün yetkisi dışında. Sıradaki Yöneticiye gidiyoruz.");
                    _nextWorker.Execute(withdraw);
                }
            }
        }
    }
}
