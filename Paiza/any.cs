using System;
using System.Collections.Generic;

class Any
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        if (data[0] % data[1] == data[2])
        {
            Console.WriteLine($"1 {-(data[0] / data[1])}");
        }
        else
        {
            Console.WriteLine($"{-(data[1] / data[0])}");
        }
    }
}
