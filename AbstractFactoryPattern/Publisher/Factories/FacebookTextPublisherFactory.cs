using AbstractFactoryPattern.Publisher.Publishers;

namespace AbstractFactoryPattern.Publisher.Factories
{
    public class FacebookTextPublisherFactory : IPublisherFactory
    {
        public IContent CreateContent(string contentHeader)
        {
            TextContent textContent = new TextContent();
            textContent.ContentHeader = contentHeader;
            textContent.MakeContent();
            return textContent;
        }

        public IPublisher CreatePublisher()
        {
            FacebookPublisher facebookPublisher = new FacebookPublisher();
            facebookPublisher.PublisherAddress = "http://www.facebook.com";
            return facebookPublisher;
        }
    }
}
