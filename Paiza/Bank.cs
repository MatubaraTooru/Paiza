using System;
using System.Collections.Generic;

class Bank
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var data = new Dictionary<Tuple<string, int>, int>();

        for (int i = 0; i < nums[0]; i++)
        {
            var tmp = Console.ReadLine().Split();
            data.Add(Tuple.Create(tmp[0], int.Parse(tmp[1])), int.Parse(tmp[2]));
        }
        for (int i = 0; i < nums[1]; i++)
        {
            var tmp = Console.ReadLine().Split();
            if (data.ContainsKey(Tuple.Create(tmp[0], int.Parse(tmp[1]))))
            {
                data[Tuple.Create(tmp[0], int.Parse(tmp[1]))] -= int.Parse(tmp[2]);
            }
        }
        foreach (var item in data)
        {
            Console.WriteLine($"{item.Key.Item1} {item.Value}");
        }
    }
}