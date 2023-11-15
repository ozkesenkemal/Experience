namespace TemplateMethodGof
{
    public abstract class GameReporter
    {
        public void GetStatistic()
        {
            Console.WriteLine("İstatistikler toplanıyor.");
        }

        public void ParseIstatistic()
        {
            Console.WriteLine("İstatistikler ayrıştırılıyor");
        }

        public abstract void WriteResult();


        public void WriteSummary()
        {
            GetStatistic();
            ParseIstatistic();
            WriteResult();
        }
    }
}