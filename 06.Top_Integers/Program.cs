using System;
using System.Linq;

namespace _06.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > number)
                {
                    number = n[i];
                }
            }
            Console.WriteLine(number);
        }
    }
}
