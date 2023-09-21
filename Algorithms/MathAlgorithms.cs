using System.Globalization;

namespace Algorithms;

public static class MathAlgorithms 
{
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

    public static int FactorialFor(int n)
    {
        int number = 1;

        for (int i = 1; i <= n; i++)
        {
            number *= i;
        }
        return number;
    }
}

