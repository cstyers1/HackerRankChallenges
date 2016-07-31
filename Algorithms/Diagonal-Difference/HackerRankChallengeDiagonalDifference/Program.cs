using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];

        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }

        int firstDiag = 0;
        int secondDiag = 0;

        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                if (first == second)
                {
                    firstDiag += (a[first][second]);
                }
                if (first + second == (n - 1))
                {
                    secondDiag += (a[first][second]);
                }
            }
        }

        Console.WriteLine(Math.Abs(firstDiag - secondDiag));
    }
}