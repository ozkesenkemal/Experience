namespace AbstractFactoryPattern.DBConnection
{
    public class PostgresqlCommand : Command
    {
        public override void Execute(string command)
        {
            Console.WriteLine($"Postgresql command executed: {command}");
        }
    }
}
