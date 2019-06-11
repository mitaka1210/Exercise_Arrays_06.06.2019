using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] number = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();


            for (int i = 0; i < number.Length; i++)
            {
                bool isItBigger = true;
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] <= number[j])
                    {
                        isItBigger = false;
                    }
                }
                if (isItBigger)
                {
                   Console.Write(number[i] + " ");
                }
               
            }
            Console.WriteLine();
        }
    }
}
