namespace KlasseTaschenrechner
{
    public static class Calculator
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Factorial(int n)
        {
            int i = n;

            while (i > 1)
            {
                i--;
                n = n * i;
            }
            return n;
        }

        public static bool CheckNumberIsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}