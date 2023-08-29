namespace AbstractFactoryPattern.DBConnection
{
    public class PostgresqlFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new PostgresqlCommand();
        }

        public override Connection CreateConnection()
        {
            return new PostgresqlConnection();
        }
    }
}
