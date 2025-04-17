namespace SimpleCalculator
{
    public class CalculationHistory {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public double Result { get; set; }

        public string MathOperation { get; set; }

        Queue<CalculationHistory> history = new Queue<CalculationHistory>();

        public CalculationHistory() {
            
        }

        public CalculationHistory(double firstNumber, double secondNumber, double result, string mathOperation) {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Result = result;
            MathOperation = mathOperation;
        }

        public void AddCalculationHistory (double firstNumber, double secondNumber, double result, string mathOperation) {
            if (history.Count == 5)
            {
                history.Dequeue();
            }
            history.Enqueue(new CalculationHistory (firstNumber, secondNumber, result, mathOperation));
        }

        public void DisplayCalculationHistory () {

        }
    }
}