namespace InterpreterGof
{
    public class M : RoleExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalPoint += 1000;
        }
    }
}
