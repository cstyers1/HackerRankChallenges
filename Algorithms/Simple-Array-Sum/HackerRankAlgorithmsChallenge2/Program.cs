﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        int[] array = new int[n - 1];
        array = arr;

        int total = 0;

        foreach (int number in array)
        {
            total += number;
        }

        Console.WriteLine(total);
    }
}