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
            int[] array = { 9, 6, 3, 2, 7, 5, 1, 8, 4 };

            Sort(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static void Sort(int[] array)
        {
            int currentElement;
            int counter;

            //index of element to be compared, index starts at 0
            for (int i = 1; i < array.Length; i++) //loop trough each element in turn
            {
                currentElement = array[i];
                counter = i - 1;

                while (counter >= 0 && array[counter] > currentElement)
                {
                    array[counter + 1] = array[counter]; //move all elements
                    counter--;
                }

                array[counter + 1] = currentElement; //Insert element
            } 
        }

     
    }
}
