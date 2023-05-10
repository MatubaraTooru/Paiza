using System;
using System.Collections.Generic;

class Any2
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        long maxnum = 0;
        long num1 = 0;
        long num2 = 0;

        for (long i = 2; i * i < n; i++)
        {
            IsPrime();
        }
    }
    static long IsPrime(long n)
    {
        if (n < 2) return 0;
        else if (n % 2 == 0) return n;
        else
        {
            for (int i = 2; i * i < n; i++)
            {
                if (n % i == 0) return 0;
            }
            return n;
        }

    }
}
