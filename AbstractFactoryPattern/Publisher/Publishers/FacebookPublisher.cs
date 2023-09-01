namespace AbstractFactoryPattern.Publisher.Publishers
{
    public class FacebookPublisher : IPublisher
    {
        public string PublisherAddress { get; set; }

        public void Publish(IContent content)
        {
            Console.WriteLine($"{PublisherAddress} used for Facebook publish");
        }
    }
}
