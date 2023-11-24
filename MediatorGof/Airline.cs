namespace MediatorGof
{
    public abstract class Airline
    {
        public IAirportControl _airportControl;
        public string _fligthNumber;
        public string _from;
        public string _way;

        private void RequestNewWay(string way)
        {
            _airportControl.SuggestWay(_fligthNumber, way);
        }

        public void RequestWay(string way)
        {
            RequestNewWay(way);
        }

        public virtual void GetWay(string messageFromAirport)
        {
            Console.WriteLine($"{messageFromAirport} rotasına yönlenmeniz gerekmektedir.");
        }
    }
}