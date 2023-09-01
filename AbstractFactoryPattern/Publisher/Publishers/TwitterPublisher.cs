namespace AbstractFactoryPattern.Publisher.Publishers
{
    public class TwitterPublisher : IPublisher
    {
        public string PublisherAddress { get; set; }

        public void Publish(IContent content)
        {
            Console.WriteLine($"{PublisherAddress} used for Twitter publish");
        }
    }
}
