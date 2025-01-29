using Calculator.Handlers;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICalculator calculator = new Calculator();
                Display.ShowInstructions();
                double num1 = InputHandler.GetNumber("Enter the first number: ");
                double num2 = InputHandler.GetNumber("Enter the second number: ");
                string operation = InputHandler.GetOperation("Enter the operation (+, -, *, /): ");
                double result = calculator.Calculate(num1, num2, operation);
                Display.ShowResult(result);
            }
            catch (Exception ex)
            {
                Display.ShowError(ex.Message);
            }
        }
    }
}