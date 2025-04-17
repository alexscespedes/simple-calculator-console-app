namespace SimpleCalculator
{
    public class CalculationHistory {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public string MathOperation { get; set; }

        public CalculationHistory(double firstNumber, double secondNumber, string mathOperation) {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            MathOperation = mathOperation;
        }
    }
}