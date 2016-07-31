using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        long n = Convert.ToInt64(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');

        long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

        long[] array = new long[n - 1];
        array = arr;

        long total = 0;

        foreach (long number in array)
        {
            total += number;
        }

        Console.WriteLine(total);
    }
}