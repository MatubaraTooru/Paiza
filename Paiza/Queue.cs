using System;
using System.Collections.Generic;

class Queue
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            var num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (num[0] == 1)
            {
                queue.Enqueue(num[1]);
            }
        }

        Console.WriteLine(queue.Count);

        foreach(var i in queue)
        {
            Console.WriteLine(i);
        }
    }
}
