namespace AbstractFactoryPattern.Publisher
{
    public class VideoContent : IContent
    {
        public string ContentHeader { get ; set; }

        public void MakeContent()
        {
            Console.WriteLine("Video content created");
        }
    }
}
