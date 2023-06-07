using System;
using System.Collections.Generic;
using System.Linq;

class OutputOfAdjacentVertices
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < data[0] * 2; i++)
        {
            var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (i == data[1] * 2)
            {
                Console.WriteLine(nums.Max());
                break;
            }
        }
    }
}
