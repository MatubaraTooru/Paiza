using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string　brackets = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < brackets.Length; i++)
        {
            if (num == 1)
            {
                Console.WriteLine("No");
                return;
            }
            else if (brackets[i] == '(')
            {
                stack.Push(brackets[i]);
            }
            else
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
        }

        Console.WriteLine("Yes");
    }
}
