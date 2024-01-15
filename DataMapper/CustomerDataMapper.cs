namespace DataMapper
{
    public class CustomerDataMapper : IDataMapper<Customer>
    {
        string IDataMapper<Customer>.ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Delete(Customer entity)
        {
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
            Console.WriteLine("Müşteri Silindi.");
        }

        public List<Customer> GetAll()
        {
            Console.WriteLine("Müşteriler getirildi.");
            return null;
        }

        public Customer GetById(int id)
        {
            Console.WriteLine("Müşteri id ye göre getirildi.");
            return null;
        }

        public int Insert(Customer entity)
        {
            Console.WriteLine("Müşteri Eklendi.");
            return 0;
        }

        public int Update(Customer entity)
        {
            Console.WriteLine("Müşteri Güncellendi.");
            return 0;
        }
    }
}
