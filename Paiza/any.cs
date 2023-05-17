using System;
using System.Collections.Generic;

class Any
{
    static void Main()
    {
        var data = int.Parse(Console.ReadLine());
        var set = new HashSet<string>();

        for (int i = 0; i < data; i++)
        {
            var str = Console.ReadLine();
            if (set.Contains(str))
            {
                Console.WriteLine("NO");
            }
            else
            {
                set.Add(str);
                Console.WriteLine("YES");
            }
        }
    }
}