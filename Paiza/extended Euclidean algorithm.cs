using System;

class ExtendedEuclideanAlgorithm
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);

        int x, y;
        int gcd = ExtendedGCD(a, b, out x, out y);

        Console.WriteLine($"{x} {y}");
    }

    static int ExtendedGCD(int a, int b, out int x, out int y)
    {
        if (b == 0)
        {
            x = 1;
            y = 0;
            return a;
        }

        int x1, y1;
        int gcd = ExtendedGCD(b, a % b, out x1, out y1);

        x = y1;
        y = x1 - (a / b) * y1;

        return gcd;
    }
}
