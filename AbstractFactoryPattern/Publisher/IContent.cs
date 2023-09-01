namespace AbstractFactoryPattern.Publisher
{
    public interface IContent
    {
        public void MakeContent();
        public string ContentHeader { get; set; }
    }
}
