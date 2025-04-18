namespace SimpleCalculator
{
    public class CalculationHistory {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public double Result { get; set; }

        public char MathOperation { get; set; }

        Queue<CalculationHistory> history = new Queue<CalculationHistory>();

        public CalculationHistory() {
            
        }

        public CalculationHistory(double firstNumber, double secondNumber, double result, char mathOperation) {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Result = result;
            MathOperation = mathOperation;
        }

        public void AddCalculationHistory (double firstNumber, double secondNumber, double result, char mathOperation) {
            if (history.Count == 5)
            {
                history.Dequeue();
            }
            history.Enqueue(new CalculationHistory (firstNumber, secondNumber, result, mathOperation));
        }

        public void DisplayCalculationHistory () {
            if (history.Count == 0)
            {
                Console.WriteLine("The queue is empty");
            }

            foreach (var calc in history)
            {
                Console.WriteLine($"{calc.FirstNumber} {calc.MathOperation} {calc.SecondNumber} = {calc.Result}");
            }
        }

        public void ClearCalculationHistory () {
            
            history.Clear();
            Console.WriteLine("Calculation history cleared.");
        }
    }
}