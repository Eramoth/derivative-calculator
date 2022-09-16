namespace DerivativeCalculator
{
    public class Formula
    {
        public static string Function {get; set;}

        public Formula(string _function)
        {
            Function = _function;
        }

        public string ShowFormula()
        // show 
        {
            return Function;
        }
    }
}