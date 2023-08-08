namespace SingleResponsibility
{
    /// <summary>
    /// This class does all the job and has multiple responsibilities
    /// </summary>
    public class WrongHotelRezervation
    {
        public List<Hotel> SearchHotel(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            List<Hotel> HotelList = new List<Hotel>();

            HotelList.AddRange(Company1SearchHotel(cityName, startDate, endDate, personCount));
            HotelList.AddRange(Company2SearchHotel(cityName, startDate, endDate, personCount));

            return HotelList.OrderBy(x => x.Name).ToList();
        }

        public List<Hotel> Company1SearchHotel(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            //Web service call
            return new List<Hotel>();
        }

        public List<Hotel> Company2SearchHotel(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            //Web service call
            return new List<Hotel>();
        }

        public bool DoRezervation(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            return true;
        }

        public void ListRezervation(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            // connect to db and list rezervations
        }
    }
}
