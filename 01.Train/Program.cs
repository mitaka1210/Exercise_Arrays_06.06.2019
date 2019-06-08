using System;
using System.Linq;

namespace Exercise_Arrays_06._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {

            int trainWagons = int.Parse(Console.ReadLine());

            int[] peopleInWagons = new int [trainWagons];

            for (int i = 0; i < peopleInWagons.Length; i++)
            {
               peopleInWagons[i] = int.Parse(Console.ReadLine());
              
            }
            Console.WriteLine(string.Join(" ", peopleInWagons));
            Console.WriteLine(peopleInWagons.Sum()); //Sum arrays

        }
        
    }
}
