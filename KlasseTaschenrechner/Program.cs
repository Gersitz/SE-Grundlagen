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

            Circle myCircle = new Circle(10);
            myCircle.Radius = 20;
            Console.WriteLine("myCircle Area:\t" + myCircle.Area());
            Console.WriteLine("myCircle Diameter:\t" + myCircle.Diameter());
            Console.WriteLine("myCircle Circumference:\t" + myCircle.Circumference());
        }
    }
}