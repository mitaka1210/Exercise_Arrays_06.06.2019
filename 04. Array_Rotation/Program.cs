using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] element1 = Console.ReadLine()
                .Split()
                .ToArray();

            string[] element2 = Console.ReadLine()
               .Split()
               .ToArray();

            //сравняваме всички елементи от втория масив с всичките елементи от първия
            for (int i = 0; i < element2.Length; i++)//
            {
                for (int j = 0; j < element1.Length; j++)
                {
                    if (element1[j] == element2[i])
                    {
                        Console.Write($"{element2[i]} ");
                    }
                }
            }
        }
    }
}
//1 1 1
//сравняваме 1 с 1, 2, 3 и където открие съвпадения печата в случая печа 1.
//1 2 3