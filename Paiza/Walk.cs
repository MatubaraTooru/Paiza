using System;
using System.Collections.Generic;

class Walk
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var array = new int[data[2] + 1];
        Random r = new Random();
        array[0] = data[1];

        for (int i = 1; i <= data[2]; i++)
        {
            int n = r.Next(1, data[0] + 1);

            while (array[i - 1] == n)
            {
                n = r.Next(1, data[0] + 1);
            }

            array[i] = n;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}
