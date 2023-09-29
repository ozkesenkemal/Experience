using System;

namespace ProxyGof
{
    public class CommandExecutorProxy : ICommandExecutor, ILoggerProxy
    {
        ICommandExecutor _commandExecutor;
        bool isAdmin = false;
        public CommandExecutorProxy(string userName, string password)
        {
            if (userName == "admin" && password == "admin")
            {
                isAdmin = true;
            }
            _commandExecutor = new CommandExecutorService();
        }

        public void Log(string message)
        {
            Console.WriteLine($"Komut loglandı {message}");
        }

        public void RunCommand(string command)
        {
            if (isAdmin)
            {
                try
                {
                    _commandExecutor.RunCommand(command);
                    Log(command);
                }
                catch (Exception ex)
                {
                    Log(ex.Message);
                }
            }
            else
            {
                if (command.ToUpper().Contains("ALTER"))
                {
                    Log("Yetkisiz komut girildi çalıştırılamaz!");
                    return;
                }
            }

            _commandExecutor.RunCommand(command);
        }
    }
}
