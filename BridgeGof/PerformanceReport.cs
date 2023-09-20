namespace BridgeGof
{
    public class PerformanceReport : Report
    {
        public PerformanceReport(IFormat format) : base(format)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Performans Raporu.");
            _format.Generate();
        }
    }
}
