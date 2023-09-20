namespace BridgeGof
{
    public abstract class Report
    {
        protected readonly IFormat _format;
        public Report(IFormat format)
        {
            _format = format;
        }
        public abstract void Display();
    }
}
