using System;
using System.Collections.Generic;

class FermatsTest
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 2;
        int fermat = 1;

        if (n % a == 0)
        {
            Console.WriteLine("NO");
        }
        for (int i = 0; i < n - 1; i++)
        {
            fermat *= a;
            fermat %= n;
        }
        if (fermat % n == 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
