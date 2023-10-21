namespace CommandGof
{
    public class CommandManager
    {
        public Queue<ICommand> _commands { get; set; }

        public CommandManager()
        {
            _commands = new Queue<ICommand>();
        }

        public void ExecuteAll()
        {
            while (_commands.Count > 0)
            {
                _commands.Dequeue().Execute();
            }
        }
    }
}
