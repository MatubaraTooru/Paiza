﻿using System;
using System.Collections.Generic;

class PrimeFactorization
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n /= i;
            }
        }
        if (n != 1)
        {
            Console.WriteLine(n);
        }
    }
}
