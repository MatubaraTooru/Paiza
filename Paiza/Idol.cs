using System;
using System.Collections.Generic;

class Idol
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        SortedSet<string> set = new SortedSet<string>();

        for (int i = 0; i < data[0];  i++)
        {
            set.Add(Console.ReadLine());
        }
        for (int i = 0; i < data[1]; i++)
        {
            var str = Console.ReadLine().Split();
            if (str[0] == "join")
            {
                set.Add(str[1]);
            }
            else if (str[0] == "leave")
            {
                set.Remove(str[1]);
            }
            else
            {
                if (set.Count > 0)
                {
                    foreach(var item in set)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}