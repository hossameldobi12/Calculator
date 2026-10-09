namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {



                Console.WriteLine("please enter the first number:");
               bool flag = double.TryParse(Console.ReadLine(), out double num1);
                Console.WriteLine("please enter the second number:");
                 flag = double.TryParse(Console.ReadLine(), out double num2);
                Console.WriteLine("please enter the operation (+, -, *, /):");
                string? operation = Console.ReadLine();
                if (operation == null)
                {
                    Console.WriteLine("Invalid operation.");
                    continue;
                }
                Calculator calculator = new Calculator();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result: {calculator.Add(num1, num2)}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {calculator.Subtract(num1, num2)}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {calculator.Multiply(num1, num2)}");
                        break;
                    case "/":
                        Console.WriteLine($"Result: {calculator.Divide(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string? continueCalculation = Console.ReadLine();
                if (continueCalculation?.ToLower() != "y")
                {
                    break;
                }

            }
        }
    }
}
