using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        Stack<int> q = new Stack<int>();
        string[] data = Console.ReadLine().Split();
        int tmp = 0;
        int i = 0;
        int j = 0;

        for (int k = 0; k < data.Length; k++)
        {
            if (int.TryParse(data[k], out tmp))
            {
                q.Push(tmp);
            }
            else if (data[k] == "+")
            {
                i = q.Pop();
                j = q.Pop();
                q.Push(i + j);
            }
            else if (data[k] == "-")
            {
                i = q.Pop();
                j = q.Pop();
                q.Push(j - i);
            }
        }

        Console.WriteLine(q.Pop());
    }
}
