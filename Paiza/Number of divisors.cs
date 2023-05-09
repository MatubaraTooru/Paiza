using System;
using System.Collections.Generic;

class NumberofDivisors
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            int tmp = 0;
            while (n % i == 0)
            {
                n /= i;
                tmp++;
            }
            numbers.Add(tmp);
        }

        int ans = numbers[0] + 1;

        for (int i = 1; i < numbers.Count; i++)
        {
            ans *= (numbers[i] + 1);
        }

        Console.WriteLine(ans);
    }
}
