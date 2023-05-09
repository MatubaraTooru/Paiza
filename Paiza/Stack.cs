using System;
using System.Collections.Generic;
using System.Linq;

class Stack
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split();

            if (int.Parse(data[0]) == 1)
            {
                stack.Push(data[1]);
            }
            else if (int.Parse(data[0]) == 2)
            {
                Console.WriteLine(stack.First());
                stack.Pop();
            }

            Console.WriteLine(string.Join(" ", stack.Reverse()));
        }
    }
}
