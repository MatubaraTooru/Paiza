using System;
using System.Collections.Generic;
using System.Linq;

class Any
{
    static void Main()
    {
        var num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Queue<int> employee = new Queue<int>();
        Queue<int> time = new Queue<int>();

        for (int i = 1; i <= data.Max(); i++)
        {
            if (employee.Count == num[1])
            {
                employee.Dequeue();
            }
            if (time.Peek() == i)
            {
                time.Dequeue();
                employee.Enqueue(1);
                Console.WriteLine(employee.Count(x => x == 1));
            }
            else
            {
                employee.Enqueue(0);
            }
        }
    }
}
