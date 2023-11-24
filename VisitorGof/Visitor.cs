namespace VisitorGof
{
    public abstract class Visitor
    {
        private string _output = "";

        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }

        public abstract void Visit(PlainText docPart);
        public abstract void Visit(BoldText docPart);
        public abstract void Visit(HyperLink docPart);
    }
}