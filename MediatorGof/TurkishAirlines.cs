namespace MediatorGof
{
    public class TurkishAirlines : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine($"Türk Havayolları uçuş no: {_fligthNumber}");
            base.GetWay(messageFromAirport);            
        }
    }
}
