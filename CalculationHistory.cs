namespace SimpleCalculator
{
    public class CalculationHistory {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public double Result { get; set; }

        public string MathOperation { get; set; }

        public CalculationHistory(double firstNumber, double secondNumber, double result, string mathOperation) {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Result = result;
            MathOperation = mathOperation;
        }
    }
}