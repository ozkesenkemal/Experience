namespace VisitorGof
{
    public class HtmlVisitor : Visitor
    {
        public override void Visit(PlainText docPart)
        {
            Output += "<p>" + docPart.Text + "</p>";
        }

        public override void Visit(BoldText docPart)
        {
            Output += "<b>" + docPart.Text + "</b>";
        }

        public override void Visit(HyperLink docPart)
        {
            Output += "<a href = \"" + docPart.Text + "</a>";
        }
    }
}
