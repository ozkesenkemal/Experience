namespace InterpreterGof
{
    public class X : RoleExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalPoint += 10;
        }
    }
}
