namespace SimpleCalculator
{
    public class HelperMethods {
        public (double num1, double num2) NumbersValidation() {

            double num1, num2;

            while(true) 
            {
                Console.Write("Enter the first number: ");
                if (double.TryParse(Console.ReadLine(), out num1)) 
                    break;
                Console.WriteLine("Invalid input! Please enter a valid number");                
            }

            while(true) 
            {
                Console.Write("Enter the second number: ");
                if (double.TryParse(Console.ReadLine(), out num2)) 
                    break;
                Console.WriteLine("Invalid input! Please enter a valid number");                
            }
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