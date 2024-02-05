using System.Data.SqlClient;

namespace RowDataGateway
{
    public class CustomerFinder
    {
        private RowDataGatewayCustomer customer = null;

        public CustomerFinder(RowDataGatewayCustomer customer)
        {
            this.customer = customer;
        }
        public SqlDataReader GetCustomerByFirstName()
        {
            Console.WriteLine("Müşteri getirildi.");
            return null;
        }

        public SqlDataReader GetCustomerByLastName()
        {
            Console.WriteLine("Müşteri getirildi.");
            return null;
        }

        public SqlDataReader GetCustomerById()
        {
            Console.WriteLine("Müşteri getirildi.");
            return null;
        }
        public SqlDataReader GetCustomers()
        {
            Console.WriteLine("Müşteri getirildi.");
            return null;
        }
    }
}
