namespace MediatorGof
{
    public class PegasusAirlines : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine($"Pegasus Havayolları uçuş no: {_fligthNumber}");
            base.GetWay(messageFromAirport);            
        }
    }
}
