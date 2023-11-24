namespace VisitorGof
{
    public class BoldText : DocumentPart
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}