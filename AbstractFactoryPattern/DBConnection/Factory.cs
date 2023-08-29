namespace AbstractFactoryPattern.DBConnection
{
    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start(string command)
        {
            _connection.Connect();
            if(_connection.State == "Open")
            {
                _command.Execute(command);
            }
        }
    }

    public class FactoryGeneric<T> where T : DatabaseFactory, new()
    {
        private T _databaseFactory;
        private Connection _connection;
        private Command _command;

        public FactoryGeneric(DatabaseFactory databaseFactory)
        {
            _databaseFactory = new T();
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start(string command)
        {
            _connection.Connect();
            if (_connection.State == "Open")
            {
                _command.Execute(command);
            }
        }
    }
}
