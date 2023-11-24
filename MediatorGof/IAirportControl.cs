namespace MediatorGof
{
    public interface IAirportControl
    {
        void Register(Airline airline);
        void SuggestWay(string fligthNumber, string way);
    }
}