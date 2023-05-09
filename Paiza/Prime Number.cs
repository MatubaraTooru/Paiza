using System;
using System.Collections.Generic;

class PrimeNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            if (Prime(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("failure");
            }
        }
    }
    static bool Prime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        else if (n == 2)
        {
            return true;
        }
        else if (n % 2 == 0)
        {
            return false;
        }
        else
        {
            for (int i = 3; i < Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            Console.WriteLine(Math.Sqrt(n));
            return true;
        }
    }
}
