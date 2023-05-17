using System;
using System.Collections.Generic;
using System.Linq;

class History
{
    static void Main()
    {
        int n, k;
        string[] input1 = Console.ReadLine().Split();
        n = int.Parse(input1[0]);
        k = int.Parse(input1[1]);
        var history = new Dictionary<int, string>();

        for (int i = 0; i < n; i++)
        {
            Console.ReadLine();
        }

        for (int i = 0; i < k; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            int year = int.Parse(input2[0]);
            string name = input2[1];
            history[year] = name;
        }

        // historyをソート
        history.OrderByDescending(h => h.Key);

        // 結果を出力
        foreach (var item in history)
        {
            Console.WriteLine(item.Value);
        }
    }
}