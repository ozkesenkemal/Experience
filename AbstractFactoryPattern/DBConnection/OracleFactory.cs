namespace AbstractFactoryPattern.DBConnection
{
    public class OracleFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new OracleCommand();
        }

        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
