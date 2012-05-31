using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numElements = 100000;
            int[] array = { 3, 2, 5, 6, 9, 8, 1, 7, 4 };
            int[] arrayLarge = new int[numElements];

            Console.WriteLine("Building list...");

            for (int i = 0; i < numElements; i++) arrayLarge[i] = rand.Next();

            Console.WriteLine("List built with [{0}] elements.", numElements);

            BubbleSort(arrayLarge);

            foreach (int i in arrayLarge)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        Swap(array, j + 1, j);
                    }
                }
            }
        }

        private static void Swap(int[] array, int p, int i)
        {
            int tmp = array[p];
            array[p] = array[i];
            array[i] = tmp;
        }
    }
}
