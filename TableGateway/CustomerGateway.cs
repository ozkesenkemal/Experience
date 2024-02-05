using System.Data.SqlClient;

namespace TableGateway
{
    public class CustomerGateway
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
         
        #region Methods
        public int AddCustomer(string firstName, string lastName, DateTime birthDate, string country)
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

        public int RemoveCustomer(int id)
        {
            Console.WriteLine("Müşteri Silindi.");
            return 0;
        }

        public int UpdateCustomer(string firstName, string lastName, DateTime birthDate, string country)
        {
            Console.WriteLine("Müşteri Güncellendi.");
            return 0;
        }

        public SqlDataReader GetCustomerByFirstName(string name)
        {
            Console.WriteLine("Müşteri ada göre getirildi.");
            return null;
        }
        #endregion
    }
}