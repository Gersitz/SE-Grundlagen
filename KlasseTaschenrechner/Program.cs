namespace KlasseTaschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = 42;
            var num2 = 21;
            var result = Calculator.Add(num1, num2);
            var result2 = Calculator.Subtract(num1, num2);
            var factorialResult = Calculator.Factorial(6);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(factorialResult);
        }
    }
}