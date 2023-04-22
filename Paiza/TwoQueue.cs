using System;
using System.Collections.Generic;

class TwoQueue
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<int> queue = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            var num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (num[0] == 1)
            {
                if (num[1] == 1)
                {
                    queue.Enqueue(num[1]);
                }
                else
                {
                    queue2.Enqueue(num[1]);
                }
            }
            else if (num[0] == 2)
            {
                if (num[1] == 1)
                {
                    Console.WriteLine(queue.Peek());
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(queue2.Peek());
                    queue2.Dequeue();
                }
            }
            else
            {
                Console.WriteLine($"{queue.Count} {queue2.Count}");
            }
        }
    }
}
