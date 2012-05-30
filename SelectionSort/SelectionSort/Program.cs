using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int maxArraySize = 100000;
            int[] array = { 9, 6, 3, 2, 7, 5, 1, 8, 4 };
            int[] largeArray = new int[maxArraySize];

            for (int i = 0; i < maxArraySize; i++) largeArray[i] = rand.Next();

            Sort(largeArray);

            foreach (int i in largeArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i; //Assume the first item in the list is the smallest

                //verify that minValue is the smallest in the list
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    //Swap
                    Swap(array, i, minIndex);
                }
            }
        }

        static void Swap(int[] array, int oldLocation, int newLocation)
        {
            int tmp = array[newLocation];
            array[newLocation] = array[oldLocation];
            array[oldLocation] = tmp;
        }

     
    }
}
