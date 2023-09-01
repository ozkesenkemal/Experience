namespace AbstractFactoryPattern.Publisher.Publishers
{
    public class InstagramPublisher : IPublisher
    {
        public string PublisherAddress { get; set; }

        public void Publish(IContent content)
        {
            Console.WriteLine($"{PublisherAddress} used for Instagram publish");
        }
    }
}
