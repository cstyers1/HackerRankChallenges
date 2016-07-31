using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    /* Instructions:
     * 
     * Consider a staircase of size n = 4:
     *
     *         #
     *        ##
     *       ###
     *      ####
     *      
     * Observe that its base and height are both equal to n, and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.
     * Write a program that prints a staircase of size n.
     */


    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine(new String('#', i).PadLeft(n, ' '));
    }
}
