namespace InterpreterGof
{
    public class I : RoleExpression
    {
        bool _isPositive = true;
        public I(bool isPositive)
        {
            _isPositive = isPositive;
        }

        public override void Interpret(Context context)
        {
            context.TotalPoint += (1 * (_isPositive ? 1 : -1));
        }
    }
}
