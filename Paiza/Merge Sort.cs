using System;
using System.Linq;

class MergeSort
{
    private static int count = 0;
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        MergeSortAlgorithm(array);
        Console.WriteLine(string.Join(" ", array));
    }

    static void MergeSortAlgorithm(int[] array)
    {
        MergeSortHelper(array, 0, array.Length);
    }

    static void MergeSortHelper(int[] array, int start, int end)
    {
        if (end - start > 1)
        {
            int middle = (start + end) / 2;

            MergeSortHelper(array, start, middle);
            MergeSortHelper(array, middle, end);

            Merge(array, start, middle, end);
        }
    }

    static void Merge(int[] array, int start, int middle, int end)
    {
        int[] temp = new int[end - start];
        int i = start;
        int j = middle;
        int k = 0;

        while (i < middle && j < end)
        {
            if (array[i] <= array[j])
            {
                temp[k] = array[i];
                i++;
            }
            else
            {
                temp[k] = array[j];
                j++;
            }
            k++;
        }

        while (i < middle)
        {
            temp[k] = array[i];
            i++;
            k++;
        }

        while (j < end)
        {
            temp[k] = array[j];
            j++;
            k++;
        }

        for (int m = 0; m < temp.Length; m++)
        {
            array[start + m] = temp[m];
        }
    }
}
