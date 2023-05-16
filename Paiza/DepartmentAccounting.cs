using System;
using System.Collections.Generic;

class DepartmentAccounting
{
    static void Main()
    {
        int n, k;
        Dictionary<string, List<Tuple<string, int>>> receipt = new Dictionary<string, List<Tuple<string, int>>>();

        // NとKを入力
        string[] input1 = Console.ReadLine().Split();
        n = int.Parse(input1[0]);
        k = int.Parse(input1[1]);

        // nameを入力
        List<string> name = new List<string>();
        for (int i = 0; i < n; i++)
        {
            name.Add(Console.ReadLine());
        }

        // receiptを入力
        for (int i = 0; i < k; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            string a = input2[0];
            string p = input2[1];
            int m = int.Parse(input2[2]);
            if (!receipt.ContainsKey(a))
            {
                receipt[a] = new List<Tuple<string, int>>();
            }
            receipt[a].Add(Tuple.Create(p, m));
        }

        // 結果を出力
        foreach (string str in name)
        {
            Console.WriteLine(str);
            foreach (var pm in receipt[str])
            {
                Console.WriteLine(pm.Item1 + " " + pm.Item2);
            }
            Console.WriteLine("-----");
        }
    }
}
