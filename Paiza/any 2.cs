using System;
using System.Collections.Generic;

class Any2
{
    static void Main()
    {
        var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = data[0];
        int m = data[1];
        string[] strArray = new string[data[0]];

        for (int i = 0; i < data[0]; i++)
        {
            strArray[i] = Console.ReadLine();
        }

        bool isLineSymmetry = LineSymmetry1(n, m, strArray) || LineSymmetry2(n, m, strArray);

        bool isPointSymmetry = PointSymmetry(n, m, strArray);

        if (isLineSymmetry && isPointSymmetry)
        {
            Console.WriteLine("line point symmetry");
        }
        else if (isLineSymmetry)
        {
            Console.WriteLine("line symmetry");
        }
        else if (isPointSymmetry)
        {
            Console.WriteLine("point symmetry");
        }
        else
        {
            Console.WriteLine("none");
        }
    }

    private static bool PointSymmetry(int n, int m, string[] strArray)
    {
        bool isPointSymmetry = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (strArray[i][j] != strArray[n - i - 1][m - j - 1])
                {
                    isPointSymmetry = false;
                }
            }
        }

        return isPointSymmetry;
    }

    private static bool LineSymmetry1(int n, int m, string[] strArray)
    {
        bool isLineSymmetry = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (strArray[i][j] != strArray[i][m - j - 1])
                {
                    isLineSymmetry = false;
                }
            }
        }

        return isLineSymmetry;
    }

    private static bool LineSymmetry2(int n, int m, string[] strArray)
    {
        bool isLineSymmetry = true;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (strArray[j][i] != strArray[n - j - 1][i])
                {
                    isLineSymmetry = false;
                }
            }
        }

        return isLineSymmetry;
    }
}
