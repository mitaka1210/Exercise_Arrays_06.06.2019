using System;
using System.Linq;

namespace _05._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int numberOfRotaions = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotaions; i++)// четем броя колко пъти трябва да го завъртим
            {

                int firstNumber = myArray[0];// винаги казваме че първия елемент е равен на първия индекс
                for (int j= 0; j < myArray.Length - 1; j++)// въртим до пред последния елемент
                {
                    myArray[j] = myArray[j + 1];

                }
                myArray[myArray.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ",myArray));
        }
    }
}
