namespace DataMapper
{
    public class Customer
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        #endregion

        #region Constructors
        public Customer()
        {

        }

        public Customer(string firstName, string lastName, DateTime birthDate, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Country = country;
        }

        public Customer(int id, string firstName, string lastName, DateTime birthDate, string country)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Country = country;
        }
        #endregion
    }
}