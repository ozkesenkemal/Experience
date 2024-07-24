namespace TableModel
{
    public class UserTableModel
    {
        // private DataSource _datasource;
        public UserTableModel(/*DataSource datasource*/)
        {
            //_datasource = datasource;
        }

        public bool Login(User user, string userName, string password)
        {
            Console.WriteLine($"{user.Id} {user.UserName} Login Success");
            return true;
        }

        public bool RegisterUser(User user)
        {
            if(user == null)
            {
                return false;
            }

            //Save(user);
            Console.WriteLine($"{user.Id} {user.UserName} User Registered");
            return true;
        }
    }
}
