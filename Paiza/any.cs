using System;
using System.Collections.Generic;

class Any
{
    static void Main()
    {
        Console.ReadLine();
        var intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < intArray.Length - 2; i++)
        {
            for (int j = intArray.Length - 1; j > 0; j--)
            {
                if (intArray[j - 1] > intArray[j])
                {
                    var temp = intArray[j - 1];
                    intArray[j - 1] = intArray[j];
                    intArray[j] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}
