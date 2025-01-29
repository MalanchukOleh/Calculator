namespace Calculator
{

        public class Calculator : ICalculator
        {
            private readonly CalculationContext _context;

            public Calculator()
            {
                _context = new CalculationContext();
            }

            public double Calculate(double num1, double num2, string operation)
            {
                return _context.ExecuteStrategy(num1, num2, operation);
            }
        }
    
}