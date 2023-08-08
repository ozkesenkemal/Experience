namespace SingleResponsibility
{
    public interface ICompany
    {
        public List<Hotel> SearchHotel(string cityName, DateTime startDate, DateTime endDate, int personCount);
    }
}
