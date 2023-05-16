using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n, k;
        string[] input1 = Console.ReadLine().Split();
        n = int.Parse(input1[0]);
        k = int.Parse(input1[1]);
        string[] s = new string[n];
        List<Tuple<int, string>> history = new List<Tuple<int, string>>();

        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
        }

        for (int i = 0; i < k; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            int year = int.Parse(input2[0]);
            string name = input2[1];
            history.Add(Tuple.Create(year, name));
        }

        // historyをソート
        history.Sort();

        // 結果を出力
        foreach (var item in history)
        {
            Console.WriteLine(item.Item2);
        }
    }
}