namespace SingleResponsibility
{
    public class BestHotelRezervation
    {
        List<Hotel> HotelList;
        readonly List<ICompany> CompanyList;

        public BestHotelRezervation(List<ICompany> companyList)
        {
            this.CompanyList = companyList;
        }

        public List<Hotel> SearchHotel(string cityName, DateTime startDate, DateTime endDate, int personCount)
        {
            HotelList = new List<Hotel>();

            foreach (var company in CompanyList)
            {
                HotelList.AddRange(company.SearchHotel(cityName, startDate, endDate, personCount));
            }

            return HotelList.OrderBy(x => x.Name).ToList();
        }
    }
}
