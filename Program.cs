namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculationHistory = new CalculationHistory();

            bool exit = false;
            bool confirmation;
            while (!exit)
            {
                Console.WriteLine("Welcome to the Simple Calculator Console App");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Subtraction");
                Console.WriteLine("3 for Multiplication");
                Console.WriteLine("4 for Division");
                Console.WriteLine("5 for Display the calculation history");
                Console.WriteLine("6 for Clear Calculation History");
                Console.WriteLine("7 for Exit the program");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int userInput)) 
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer");
                        continue;
                    }

                var operation = new MathOperation();
                var numbersCalculation = new HelperMethods();

                switch (userInput)
                {
                    case 1:
                        do
                        {
                        // Addition
                        Console.WriteLine("Addition");
                        var numAdd = numbersCalculation.NumbersValidation();
                        var addOpResult = operation.Addition(numAdd.num1, numAdd.num2);
                        Console.WriteLine(addOpResult);
                        // history Calculation Feature
                        calculationHistory.AddCalculationHistory(numAdd.num1, numAdd.num2, addOpResult, '+');

                        confirmation = numbersCalculation.MultipleCalculation();
                        } while (confirmation);
                        break;
                    case 2:
                        do
                        {
                        // Subtraction
                        Console.WriteLine("Subtraction");
                        var numSub = numbersCalculation.NumbersValidation();
                        var subOpResult = operation.Subtraction(numSub.num1, numSub.num2);
                        Console.WriteLine(subOpResult);
                        // history Calculation Feature
                        calculationHistory.AddCalculationHistory(numSub.num1, numSub.num2, subOpResult, '-');

                        confirmation = numbersCalculation.MultipleCalculation();
                        } while (confirmation);
                        break;
                    case 3:
                        do
                        {
                        // Multiplication
                        Console.WriteLine("Multiplication");
                        var numMult = numbersCalculation.NumbersValidation();
                        var mulOpResult = operation.Multiplication(numMult.num1, numMult.num2);
                        Console.WriteLine(mulOpResult);
                        // history Calculation Feature
                        calculationHistory.AddCalculationHistory(numMult.num1, numMult.num2, mulOpResult, '*');

                        confirmation = numbersCalculation.MultipleCalculation();
                        } while (confirmation);
                        break;
                    case 4:
                        do
                        {
                        // Division
                        Console.WriteLine("Division");
                        var numDiv = numbersCalculation.NumbersValidation();
                        while (numDiv.num2 == 0)
                        {
                            Console.Write("Enter a non-zero divisor: ");
                            numDiv.num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        var divOpResult = operation.Division(numDiv.num1, numDiv.num2);
                        Console.WriteLine(divOpResult);   
                        // history Calculation Feature
                        calculationHistory.AddCalculationHistory(numDiv.num1, numDiv.num2, divOpResult, '/');

                        confirmation = numbersCalculation.MultipleCalculation();
                        } while (confirmation);                    
                        break;
                    case 5:
                        Console.WriteLine("Display the history of calculation");
                        calculationHistory.DisplayCalculationHistory();
                        break;
                    case 6:
                        calculationHistory.ClearCalculationHistory();
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }
            }
        }

    }
}