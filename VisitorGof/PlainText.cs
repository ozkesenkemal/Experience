namespace VisitorGof
{
    public class PlainText : DocumentPart
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}