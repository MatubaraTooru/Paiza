using System;

class ChineseRemainderTheorem
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long m1 = data[0];
        long m2 = data[1];
        long b1 = data[2];
        long b2 = data[3];

        for (int i = 0; i < m2; i++)
        {
            long cand = m1 * i + b1;
            if (cand % m2 == b2)
            {
                Console.WriteLine(cand);
                break;
            }
        }
    }
}