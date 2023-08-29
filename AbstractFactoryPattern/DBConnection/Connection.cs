namespace AbstractFactoryPattern.DBConnection
{
    public abstract class Connection
    {
        public abstract void Connect();
        public abstract void Disconnect();
        public abstract string State { get; }
    }
}
