namespace SimpleCalculator
{
    public class MathOperation {

        public double Addition(double x, double y) {
            return x + y;
        }

        public double Subtraction(double x, double y) {
            return x - y;
        }

        public double Multiplication(double x, double y) {
            return x * y;
        }

        public double Division(double x, double y) {
            return Math.Round(x / y, 2);
        }
    }
}