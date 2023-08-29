namespace AbstractFactoryPattern.DBConnection
{
    public class OracleConnection : Connection
    {
        public override string State { get { return "Open"; } }

        public override void Connect()
        {
            Console.WriteLine("Oracle connection opened");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }
}
