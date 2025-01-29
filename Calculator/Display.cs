namespace Calculator
{
    public static class Display
    {
        public static void ShowInstructions()
        {
            Console.WriteLine("Console Calculator");
            Console.WriteLine("==================");
            Console.WriteLine("Available operations:");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");
            Console.WriteLine("Enter numbers followed by the operation(Number format e.g.:3,5 2,8 etc)");
            Console.WriteLine("----------------------------------------");
        }

        public static void ShowResult(double result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {result.ToString("F2")}");
            Console.ResetColor();
        }

        public static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
        }
    }
}