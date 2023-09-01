using AbstractFactoryPattern.Publisher;

namespace AbstractFactoryPattern
{
    public interface IPublisherFactory
    {
        public IContent CreateContent(string contentHeader);
        public IPublisher CreatePublisher();
    }
}
