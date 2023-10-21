namespace InterpreterGof
{
    public class D : RoleExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalPoint += 500;
        }
    }
}
