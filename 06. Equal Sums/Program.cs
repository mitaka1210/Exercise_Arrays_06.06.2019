﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int sumLeft = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0)
                {
                    sumLeft += numbers[i - 1];
                }

                int sumRight = 0;
                for (int j = i + 1; j < numbers.Length; 
                    j++)
                {
                    sumRight += numbers[j];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}