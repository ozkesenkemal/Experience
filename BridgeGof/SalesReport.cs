namespace BridgeGof
{
    public class SalesReport : Report
    {
        public SalesReport(IFormat format) : base(format)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Satış Raporu.");
            _format.Generate();
        }
    }
}
