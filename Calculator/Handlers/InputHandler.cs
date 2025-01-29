namespace Calculator.Handlers
{
    public static class InputHandler
    {
        public static double GetNumber(string message)
        {
            const double MAX_VALUE = 1e308;

            Console.Write(message);

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    if (number > MAX_VALUE)
                    {
                        Display.ShowError($"Number is too large. Please enter a number lower than {MAX_VALUE}.");
                    }
                    else
                    {
                        return number;
                    }
                }
                else
                {
                    Display.ShowError("Invalid input. Please enter a valid number.");
                }

                Console.Write(message);
            }
        }


        public static string GetOperation(string message)
        {
            Console.Write(message);

            while (true)
            {
                string input = Console.ReadLine()?.Trim();

                if (input is "+" or "-" or "*" or "/")
                    return input;

                Display.ShowError("Invalid operation. Please enter a valid operation (+, -, *, /).");
                Console.Write(message);
            }
        }
    }
}
