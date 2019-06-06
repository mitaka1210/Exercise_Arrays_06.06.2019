using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int[] fromLeftDiagonal = new int[number];

            int[] fromRighDiagonal = new int[number];


            for (int i = 0; i < number; i++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    fromLeftDiagonal[i] = currentArray[0];
                    fromRighDiagonal[i] = currentArray[1];

                }
                else
                {
                    fromLeftDiagonal[i] = currentArray[1];
                    fromRighDiagonal[i] = currentArray[0];
                }
               
                
            }
            Console.WriteLine(string.Join(" ", fromLeftDiagonal));
            Console.WriteLine(string.Join(" ", fromRighDiagonal));
            

          
        }
    }
}
