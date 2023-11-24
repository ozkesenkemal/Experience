namespace MediatorGof
{
    public class KatarAirlines : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine($"Katar Havayolları uçuş no: {_fligthNumber}");
            base.GetWay(messageFromAirport);            
        }
    }
}
