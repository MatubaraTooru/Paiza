using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        Queue<int> q = new Queue<int>();
        int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int l = 0;
        int max = 0;
        int sum = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            q.Enqueue(ints[i]);
            sum += ints[i];

            if (q.Count >= int.Parse(inputs[1]))
            {
                if (max < sum)
                {
                    max = sum;
                    l = q.Peek();
                }
                sum -= q.Dequeue();
            }
        }

        Console.WriteLine($"{max} {l}");
    }
}
