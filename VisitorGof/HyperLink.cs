namespace VisitorGof
{
    public class HyperLink : DocumentPart
    {
        public string Url { get; set; }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}