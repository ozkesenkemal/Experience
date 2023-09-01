using AbstractFactoryPattern.Publisher;

namespace AbstractFactoryPattern
{
    public class Publisher<T> where T : IPublisherFactory, new()
    {
        private readonly IContent _content;
        private readonly IPublisher _publisher;
        private readonly T _factory;

        public Publisher(string contentHeader)
        {
            _factory = new T();
            _content = _factory.CreateContent(contentHeader);
            _publisher = _factory.CreatePublisher();
        }

        public void Publish()
        {
            _publisher.Publish(_content);
        }
    }
}
