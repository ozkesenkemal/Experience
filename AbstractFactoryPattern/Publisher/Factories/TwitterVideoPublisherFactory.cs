using AbstractFactoryPattern.Publisher.Publishers;

namespace AbstractFactoryPattern.Publisher.Factories
{
    public class TwitterVideoPublisherFactory : IPublisherFactory
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
            TwitterPublisher twitterPublisher = new TwitterPublisher();
            twitterPublisher.PublisherAddress = "http://www.twitter.com";
            return twitterPublisher;
        }
    }
}
