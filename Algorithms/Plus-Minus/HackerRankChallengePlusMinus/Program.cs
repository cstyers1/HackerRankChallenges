using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {

        double n = Convert.ToDouble(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        double[] arr = Array.ConvertAll(arr_temp, double.Parse);

        double posNumber = 0;
        double negNumber = 0;
        double zeroNumber = 0;

        foreach (double number in arr)
        {
            if (number > 0)
            {
                posNumber++;
            }           
            else if (number < 0)
            {
                negNumber++;
            }
            else if (number == 0)
            {
                zeroNumber++;
            }
        }

        Console.WriteLine(posNumber / n);       
        Console.WriteLine(negNumber / n);
        Console.WriteLine(zeroNumber / n);
    }
}
