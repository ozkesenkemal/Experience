namespace TemplateMethodGof
{
    public class JsonReport : GameReporter
    {
        public override void WriteResult()
        {
            Console.WriteLine("Json formatta rapor çıkıldı.");
        }
    }
}
