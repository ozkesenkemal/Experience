namespace SingleResponsibility
{
    public class BetterHotelRezervation
    {
        Company1 company1 = new Company1();
        Company2 company2 = new Company2();
        List<Hotel> HotelList;
        public List<Hotel> SearchHotel(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            HotelList = new List<Hotel>();
            HotelList.AddRange(company1.SearchHotel(cityName, startDate, endDate, personCount));
            HotelList.AddRange(company2.SearchHotel(cityName, startDate, endDate, personCount));
            return HotelList.OrderBy(x => x.Name).ToList();
        }
    }
}
