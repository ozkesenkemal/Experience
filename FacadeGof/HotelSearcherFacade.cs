using System;
using System.Collections.Generic;

namespace FacadeGof
{
    public class HotelSearcherFacade
    {
        private readonly AddressChecker _addressChecker;
        private readonly PriceChecker _priceChecker;
        private readonly SecurityChecker _securityChecker;

        public HotelSearcherFacade()
        {
            _addressChecker = new AddressChecker();
            _priceChecker = new PriceChecker();
            _securityChecker = new SecurityChecker();
        }

        public void SearchHotel(string nationalIdentityNo)
        {
            Console.WriteLine("Veritabanından oteller alındı.");
            List<Hotel> hotelLitst = new List<Hotel>()
            {
                new Hotel { Name = "Rixos", Price = 100, Address = "Belek", EmptyRoomCount = 23 },
                new Hotel { Name = "Hilton", Price = 200, Address = "İstanbul", EmptyRoomCount = 51 }
            };

            foreach (var hotel in hotelLitst)
            {
                Console.WriteLine($"{hotel.Name} için çalışıyor.");
                _addressChecker.CheckAddress();
                _priceChecker.CheckPrice();
                _securityChecker.CheckSecurity();
            }
        }
    }
}
