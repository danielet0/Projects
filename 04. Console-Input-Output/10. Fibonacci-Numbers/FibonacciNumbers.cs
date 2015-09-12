﻿using System;
using System.Collections.Generic;
using System.Linq;

class FibonacciNumbers
{
    static void Main()
    {

        long n;
        string intro = "This program reads a number n and prints on the console the first n members\n" +
        "of the Fibonacci sequence, using the formula: F_n = (phi^n - (1 - phi)^n) / sqrt(5)\n";

        string output = "\nThe first {0} members of the Fibonacci sequence are:\n{1}\n";

        double phi = (1 + Math.Sqrt(5)) / 2; 

        Console.SetBufferSize(100, 100);
        Console.SetWindowSize(100, 30);

        Console.WriteLine(intro);
        do 
            Console.Write(@"Please, enter an integer value >= 0 and <= 74 
(longer sequences will produce values which cannot be stored into a type long number): ");
        while (!long.TryParse(Console.ReadLine(), out n) || n <= 0);

        double[] nums = new double[n];

        for (int i = 0; i < n; i++)
            nums[i] = Math.Round((Math.Pow(phi, i) - Math.Pow((1 - phi), i)) / Math.Sqrt(5));

        Console.WriteLine(output, n, string.Join(", ", nums));
    }
}

