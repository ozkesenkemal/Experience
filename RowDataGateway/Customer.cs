using System.Data.SqlClient;

namespace RowDataGateway
{
    public class RowDataGatewayCustomer
    {
        #region Statements
        public string insertStatement = "insert into customer(FirstName,LastName,Birthdate,Country)" +
            "Values (@FirstName,@LastName,@Birthdate,@Country)";

        public string deleteStatement = "Delete from customer where id = @id";

        public string updateStatement = "update customer set FirstName = @FirstName ,LastName = @LastName" +
                ",Birthdate = @Birthdate,Country =@Country)" +
                "where id = @id";

        public string selectAllStatement = "select * from customer";

        public string selectByIdStatement = "select * from customer where id = @id";

        public string selectByLastNameStatement = "select * from customer where LastName = @LastName";
        #endregion

        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        #endregion

        #region Constructors
        public RowDataGatewayCustomer()
        {

        }

        public RowDataGatewayCustomer(string firstName, string lastName, DateTime birthDate, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Country = country;
        }

        public RowDataGatewayCustomer(int id, string firstName, string lastName, DateTime birthDate, string country)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Country = country;
        }
        #endregion

        #region Methods
        public int AddCustomer()
        {
            Console.WriteLine("Müşteri Eklendi.");
            int result = 0;
            //using (SqlConnection conn = new SqlConnection(""))
            //{
            //    SqlCommand cmd = conn.CreateCommand();
            //    cmd.Connection = conn;
            //    cmd.Parameters.Add(new SqlParameter("FirstName", firstName));
            //    cmd.Parameters.Add(new SqlParameter("LastName", lastName));
            //    cmd.Parameters.Add(new SqlParameter("BirthDate", birthDate));
            //    cmd.Parameters.Add(new SqlParameter("Country", country));
            //    conn.Open();
            //    result = cmd.ExecuteNonQuery();
            //}
            return result;
        }

        public int RemoveCustomer()
        {
            Console.WriteLine("Müşteri Silindi.");
            return 0;
        }

        public int UpdateCustomer()
        {
            Console.WriteLine("Müşteri Güncellendi.");
            return 0;
        }

        public SqlDataReader GetCustomerByFirstName()
        {
            Console.WriteLine("Müşteri ada göre getirildi.");
            return null;
        }

        public SqlDataReader GetCustomerById()
        {
            Console.WriteLine("Müşteri getirildi.");
            return null;
        }

        public SqlDataReader GetCustomerByOtherBusinessRule()
        {
            Console.WriteLine("Müşteri business kurala göre getirildi.");
            return null;
        }
        #endregion

    }
}