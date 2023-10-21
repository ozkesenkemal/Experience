namespace InterpreterGof
{
    public class L : RoleExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalPoint += 50;
        }
    }
}
