namespace InterpreterGof
{
    public class V : RoleExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalPoint += 5;
        }
    }
}
