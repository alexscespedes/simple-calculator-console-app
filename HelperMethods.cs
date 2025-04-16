namespace SimpleCalculator
{
    public class HelperMethods {
        // private List<double> numbers = new List<double>();
        public (double num1, double num2) NumbersValidation() {
            Console.Write("Enter the first number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1)) 
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer");
                }
            // numbers.Add(num1);
            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2)) 
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer");
                }
            // numbers.Add(num2);

            return (num1, num2);
        }

        public bool MultipleCalculation() {
            Console.Write("Do you want to perform another calculation (Y/N): ");
            string? userConfirmation = Console.ReadLine()?.Trim().ToUpper();
                                        
            if (userConfirmation == "N" || userConfirmation == "NO")
            {
                return false;
            }
            else if (userConfirmation == "Y" || userConfirmation == "YES")
            {
                return true;
            }
            else 
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }
    }
}