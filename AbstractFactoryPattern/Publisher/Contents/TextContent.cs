namespace AbstractFactoryPattern.Publisher
{
    public class TextContent : IContent
    {
        public string ContentHeader { get ; set; }

        public void MakeContent()
        {
            Console.WriteLine("Text content created");
        }
    }
}
