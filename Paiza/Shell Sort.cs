using System;
using System.Linq;

class ShellSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int k = int.Parse(Console.ReadLine());
        int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();

        ShellSortAlgorithm(a, h, k);
    }

    static void ShellSortAlgorithm(int[] a, int[] h, int k)
    {
        for (int i = 0; i < k; i++)
        {
            InsertionSort(a, h[i]);
        }
    }

    static void InsertionSort(int[] a, int h)
    {
        int num_of_move = 0;

        for (int i = h; i < a.Length; i++)
        {
            int x = a[i];
            int j = i - h;

            while (j >= 0 && a[j] > x)
            {
                a[j + h] = a[j];
                j -= h;
                num_of_move++;
            }

            a[j + h] = x;
        }

        Console.WriteLine(num_of_move);
    }
}
