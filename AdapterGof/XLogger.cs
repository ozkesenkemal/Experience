namespace AdapterGof
{
    internal class XLogger
    {
        public void LogError(string text)
        {
            Console.WriteLine($"XLogger ile loglama yapıldı. {text}");
        }
    }
}
