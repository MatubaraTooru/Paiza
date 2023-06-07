using System;
using System.Collections.Generic;

class Selectsort
{
    static void Main()
    {
        Console.ReadLine();
        int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < intArray.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < intArray.Length; j++)
            {
                if (intArray[minIndex] > intArray[j])
                {
                    minIndex = j;
                }
            }
            if (intArray[minIndex] != intArray[i])
            {
                var temp = intArray[minIndex];
                intArray[minIndex] = intArray[i];
                intArray[i] = temp;
            }

            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}
