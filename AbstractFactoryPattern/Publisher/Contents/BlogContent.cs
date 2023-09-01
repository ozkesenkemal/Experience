namespace AbstractFactoryPattern.Publisher
{
    public class BlogContent : IContent
    {
        public string ContentHeader { get ; set; }

        public void MakeContent()
        {
            Console.WriteLine("Blog content created");
        }
    }
}
