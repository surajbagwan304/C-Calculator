namespace Calculator
{
    public class Calculator
    {
        public double add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero!");
            }
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();

            Console.Write("Enter Num1: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Num2: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());

            // Perform some operations and print the results
            double resultAdd = myCalculator.add(Num1, Num2);
            Console.WriteLine( Num1 + " + " + Num2 + " = " + resultAdd); 

            double resultSubtract = myCalculator.subtract(Num1, Num2);
            Console.WriteLine(Num1 + " - " + Num2 + " = " + resultSubtract); 

            double resultMultiply = myCalculator.multiply(Num1, Num2);
            Console.WriteLine(Num1 + " * " + Num2 + " = " + resultMultiply); 

            double resultDivide = myCalculator.divide(Num1, Num2);
            Console.WriteLine(Num1 + " / " + Num2 + " = " + resultDivide); 

            //try
            //{
            //    myCalculator.divide(5.0, 0.0);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Error: " + e.Message); 
            //}
        }
    }
}
