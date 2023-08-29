namespace AbstractFactoryPattern.DBConnection
{
    public class OracleCommand : Command
    {
        public override void Execute(string command)
        {
            Console.WriteLine($"Oracle command executed: {command}");
        }
    }
}
