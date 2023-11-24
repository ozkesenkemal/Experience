using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorGof
{
    public class SabihaGokcenAirControl : IAirportControl
    {
        private readonly Dictionary<string, Airline> _planes;

        public SabihaGokcenAirControl()
        {
            _planes = new Dictionary<string, Airline>();
        }

        public void Register(Airline airline)
        {
            if(!_planes.ContainsValue(airline))
            {
                _planes[airline._fligthNumber] = airline;
            }

            airline._airportControl = this;
        }

        public void SuggestWay(string fligthNumber, string way)
        {
            if(!_planes.Values.Any(x=> x._way == way &&
                                   x._fligthNumber != fligthNumber))
            {
                Console.WriteLine($"Kendi rotanıza inebilirsiniz. {way}");
            }
            else
            {
                Random rnd = new Random();
                _planes[fligthNumber].GetWay(string.Format("{0}: {1}", rnd.Next(0, 100), rnd.Next(0, 100)));
            }
        }
    }
}
