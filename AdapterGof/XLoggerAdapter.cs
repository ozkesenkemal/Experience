namespace AdapterGof
{
    public class XLoggerAdapter : ILogger
    {
        private readonly XLogger XLogger;
        public XLoggerAdapter()
        {
            XLogger = new XLogger();
        }
        public void Log(string text)
        {
            XLogger.LogError(text);
        }
    }
}
