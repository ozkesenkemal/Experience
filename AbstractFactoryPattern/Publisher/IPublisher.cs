namespace AbstractFactoryPattern.Publisher
{
    public interface IPublisher
    {
        public void Publish(IContent content);
        string PublisherAddress { get; set; }
    }
}
