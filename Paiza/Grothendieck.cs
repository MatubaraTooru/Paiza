using System;
using System.Collections.Generic;

class ProgGrothendieckram
{
    static void Main()
    {
        int num = 57;
        Prime(num);
    }
    static void Prime(int n)
    {
        if (n < 2)
        {
            Console.WriteLine("NO");
        }
        else if (n == 2)
        {
            Console.WriteLine("YES");
        }
        else if (n % 2 == 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            for (int i = 3; i < Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
