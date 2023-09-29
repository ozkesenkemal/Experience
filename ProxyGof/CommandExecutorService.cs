using System;

namespace ProxyGof
{
    internal class CommandExecutorService : ICommandExecutor
    {
        public void RunCommand(string command)
        {
            Console.WriteLine($"Komut çalıştırıldı. Komut: {command}");
        }
    }
}
