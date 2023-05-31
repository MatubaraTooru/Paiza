using System;
using System.Collections.Generic;

class EuclideanAlgorithm
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            f = GCD(f, int.Parse(Console.ReadLine()));
        }

        Console.WriteLine(f);
    }

    static int GCD(int a, int b)
    {
        if (b != 0)
        {
            return GCD(b, a % b);
        }

        return a;
    }
}