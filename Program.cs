﻿using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPeak findPeak = new FindPeak(new int[]{1,2,3,4,5});
            Console.WriteLine("---------Start Find Peak----------");
            Console.WriteLine("---------Big O----------");
            Console.WriteLine("Input : {1,2,3,4,5}");
            Console.WriteLine($"Output : {findPeak.FindPeakBigO()}");
            Console.WriteLine("Input : {1,2,3,7,5}");
            findPeak = new FindPeak(new int[]{1,2,3,7,5});
            Console.WriteLine($"Output : {findPeak.FindPeakBigO()}");
            Console.WriteLine("---------End Find Peak----------");
        }
    }
}
