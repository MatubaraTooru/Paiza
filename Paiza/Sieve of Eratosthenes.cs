using System;
using System.Collections.Generic;

class SieveofEratosthenes
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool[] is_prime = new bool[num + 1];

        for (int i = 0; i < is_prime.Length; i++)
        {
            is_prime[i] = true;
        }
        is_prime[0] = false;
        is_prime[1] = false;

        for (int i = 0; i <= num; i++)
        {
            if (is_prime[i])
            {
                for (int j = i * 2; j <= num; j += i)
                {
                    is_prime[j] = false;
                }
            }
        }

        if (is_prime[num])
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
