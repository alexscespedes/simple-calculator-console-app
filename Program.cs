namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the Simple Calculator Console App");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Subtraction");
                Console.WriteLine("3 for Multiplication");
                Console.WriteLine("4 for Division");
                Console.WriteLine("5 for Exit the program");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int userInput)) 
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer");
                        continue;
                    }

                var operation = new MathOperation();
                
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Addition");
                        break;
                    case 2:
                        Console.WriteLine("Subtraction");
                        break;
                    case 3:
                        Console.WriteLine("Multiplication");
                        break;
                    case 4:
                        Console.WriteLine("Division");
                        Console.Write("Enter the first number: ");
                        if (!int.TryParse(Console.ReadLine(), out int num1)) 
                                {
                                }
                        Console.Write("Enter the second number: ");
                        if (!int.TryParse(Console.ReadLine(), out int num2)) 
                                {
                                    Console.WriteLine("Invalid input! Please enter a valid integer");
                                    break;
                                }
                        while (num2 == 0)
                        {
                            Console.Write("Enter a non-zero divisor: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        var opResult = operation.Division(num1, num2);
                        Console.WriteLine(opResult);                       
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        exit = true;
                        break;
                    default:
                        break;
                }

            }
        }


    }
}