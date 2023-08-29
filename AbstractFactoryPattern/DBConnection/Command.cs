namespace AbstractFactoryPattern.DBConnection
{
    public abstract class Command
    {
        public abstract void Execute(string command);
    }
}
