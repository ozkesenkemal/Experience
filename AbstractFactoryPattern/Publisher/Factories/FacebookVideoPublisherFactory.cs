using AbstractFactoryPattern.Publisher.Publishers;

namespace AbstractFactoryPattern.Publisher.Factories
{
    public class FacebookVideoPublisherFactory : IPublisherFactory
    {
        public IContent CreateContent(string contentHeader)
        {
            VideoContent videoContent = new VideoContent();
            videoContent.ContentHeader = contentHeader;
            videoContent.MakeContent();
            return videoContent;
        }

        public IPublisher CreatePublisher()
        {
            FacebookPublisher facebookPublisher = new FacebookPublisher();
            facebookPublisher.PublisherAddress = "http://www.facebook.com";
            return facebookPublisher;
        }
    }
}
