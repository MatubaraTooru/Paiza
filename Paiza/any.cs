using System;
using System.Collections.Generic;

class Any
{
    static void Main()
    {
        var data = int.Parse(Console.ReadLine());
        var intlist = new List<int>();

        for (int i = 0; i <  data; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                intlist.Add(n);
            }
        }
        intlist.Sort();
        foreach (int n in intlist)
        {
            Console.WriteLine(n);
        }
    }
}