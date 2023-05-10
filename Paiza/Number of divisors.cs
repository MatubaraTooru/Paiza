using System;
using System.Collections.Generic;

class NumberofDivisors
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 2; i * i < n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
