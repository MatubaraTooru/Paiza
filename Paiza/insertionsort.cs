using System;
using System.Collections;
using System.Collections.Generic;

class insertionsort
{
    static void Main()
    {
        Console.ReadLine();
        int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 1; i < intArray.Length; i++)
        {
            InsertSort(intArray, i);
        }

        Console.WriteLine(string.Join(" ", intArray));
    }
    static void InsertSort(int[] array, int n)
    {
        if (n > 0 && array[n] < array[n - 1])
        {
            // (array[n], array[n - 1]) = (array[n - 1], array[n]);
            var value = array[n];
            array[n] = array[n - 1];
            array[n - 1] = value;
            Console.WriteLine(string.Join(" ", array));
            InsertSort(array, n - 1);
        }
    }
}
