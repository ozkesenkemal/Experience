namespace InterpreterGof
{
    public class ExpressionRunner
    {
        public void RunExpression(Context context)
        {
            foreach (var expression in CreateExpressionTree(context.Formula))
            {
                expression.Interpret(context);
            }
            Console.WriteLine($"{context.Formula} için toplam skor: {context.TotalPoint}");
        }

        private List<RoleExpression> CreateExpressionTree(string formula)
        {
            List<RoleExpression> expressionList = new List<RoleExpression>();
            for (int i = 0; i < formula.Length; i++)
            {
                if(formula[i] == 'M')
                {
                    expressionList.Add(new M());
                }
                else if (formula[i] == 'D')
                {
                    expressionList.Add(new D());
                }
                else if (formula[i] == 'C')
                {
                    expressionList.Add(new C());
                }
                else if (formula[i] == 'L')
                {
                    expressionList.Add(new L());
                }
                else if (formula[i] == 'X')
                {
                    expressionList.Add(new X());
                }
                if (formula[i] == 'V')
                {
                    expressionList.Add(new V());
                }
                else if (formula[i] == 'I' &&
                         i + 1 < formula.Length &&
                         formula[i+1] != 'I')
                {
                    expressionList.Add(new I(false));
                }
                else if (formula[i] == 'I')
                {
                    expressionList.Add(new I(true));
                }
            }
            return expressionList;
        }
    }
}
