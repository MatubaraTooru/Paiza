using System;
using System.Collections.Generic;
using System.IO;

class GraphPath
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var array = new int[data[2] + 1];
        array[0] = data[1];
        var n = data[0];

        for (int i = 1; i <= data[2]; i++)
        {
            array[i] = n;
            n--;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}
