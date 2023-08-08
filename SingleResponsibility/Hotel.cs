namespace SingleResponsibility
{
    public class Hotel
    {
        private readonly string HotelName;
        public Hotel(string hotelName)
        {
            HotelName = hotelName;
        }

        public string Name { get { return HotelName; } }
    }
}
