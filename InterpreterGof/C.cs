namespace InterpreterGof
{
    public class C : RoleExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalPoint += 100;
        }
    }
}
