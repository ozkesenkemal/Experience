namespace AbstractFactoryPattern.DBConnection
{
    public class PostgresqlConnection : Connection
    {
        public override string State { get { return "Open"; } }

        public override void Connect()
        {
            Console.WriteLine("Postgresql connection opened");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Postgresql connection closed");
        }
    }
}
