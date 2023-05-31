using System;
using System.Collections.Generic;

class LeastCommonMultiple
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = data[0];
        int b = data[1];
        int ans = (a * b) / (GCD(a, b));
        Console.WriteLine(ans);
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return GCD(b, a % b);
    }
}