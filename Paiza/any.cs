using System;

class Any
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        int gcd = a[0];
        for (int i = 1; i < n; i++)
        {
            gcd = GCD(gcd, a[i]);
        }

        Console.WriteLine(gcd);
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b);
        }
    }
}