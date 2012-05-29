using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisher_Yates
{
    class Program
    {
        static Random _random = new Random();

        static void Main(string[] args)
        {
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                OriginalFisherYatesShuffle(array);
                foreach (int value in array)
                {
                    Console.WriteLine(value);
                }
            }
            {
                string[] array = { "dot", "net", "perls" };
                OriginalFisherYatesShuffle(array);
                foreach (string value in array)
                {
                    Console.WriteLine(value);
                }
            }

            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                foreach (var value in NewRandomizeStrings(array))
                {
                    Console.WriteLine(value);
                }
            }

            {
                string[] array = { "dot", "net", "perls" };

                foreach (var value in NewRandomizeStrings(array))
                {
                    Console.WriteLine(value);
                }
            }

            Console.ReadKey();
        }

        public static T[] NewRandomizeStrings<T>(T[] arr)
        {
            List<KeyValuePair<int, T>> list = new List<KeyValuePair<int, T>>();
            // Add all strings from array
            // Add new random int each time
            foreach (T s in arr)
            {
                list.Add(new KeyValuePair<int, T>(_random.Next(), s));
            }
            // Sort the list by the random number
            var sorted = from item in list
                         orderby item.Key
                         select item;

            // Allocate new string array
            T[] result = new T[arr.Length];
            // Copy values to array
            int index = 0;
            foreach (KeyValuePair<int, T> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array
            return result;
        }


        public static void OriginalFisherYatesShuffle<T>(T[] array)
        {
            var random = _random;

            for (int i = array.Length; i > 1; i--)
            {
                // Pick a random element to swap
                int j = random.Next(i);

                //Swap
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }


    }
}
