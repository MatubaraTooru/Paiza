using System;
using System.Collections.Generic;

class LimitedtoOneperPerson
{
    static void Main()
    {
        var data = int.Parse(Console.ReadLine());
        var list = new List<string>();

        for (int i = 0; i < data; i++)
        {
            var str = Console.ReadLine();
            if (list.Contains(str))
            {
                Console.WriteLine("NO");
            }
            else
            {
                list.Add(str);
                Console.WriteLine("YES");
            }
        }
    }
}