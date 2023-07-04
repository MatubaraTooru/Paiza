using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static List<int>[] adList;
    static List<int> maxTrail = new List<int>();
    static int maxPasscount = 0;

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int s = int.Parse(input[1]);
        int t = int.Parse(input[2]);
        int p = int.Parse(input[3]);

        adList = new List<int>[n + 1];

        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            adList[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        DFS(s, p, t, new List<int> { s }, new List<List<int>>());
        Console.WriteLine(string.Join(" ", maxTrail));
    }

    static void DFS(int v, int point, int target, List<int> trail, List<List<int>> edges)
    {
        foreach (int i in adList[v])
        {
            List<int> e = new List<int> { i, v };
            e.Sort();
            int pcount = 0;

            if (!edges.Any(x => x.SequenceEqual(e)))
            {
                trail.Add(i);
                edges.Add(e);

                if (i == target)
                {
                    foreach (int x in trail)
                    {
                        if (x == point)
                        {
                            pcount++;
                        }
                    }
                    if (maxTrail.Count < trail.Count)
                    {
                        maxTrail = new List<int>(trail);
                    }
                }
                
                DFS(i, point, target, trail, edges);

                edges.Remove(e);

                trail.RemoveAt(trail.Count - 1);
            }
        }
    }
}
