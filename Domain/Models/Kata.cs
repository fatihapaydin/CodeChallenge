using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class Kata
    {
        public static double SumArray(double[] array)
        {
            return array.Sum();
        }


        public static bool Hero(int bullets, int dragons)
        {
            int requiredBulletsCount = dragons * 2;

            return bullets >= requiredBulletsCount;
        }

        public static int[] GenerateRange(int min, int max, int step)
        {
            var list = new List<int>();

            var element = min;

            while (element <= max)
            {
                list.Add(element);
                element += step;
            }

            return list.ToArray();
        }

        public int[] FillAnArrayPart1(int count)
        {
            var array = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        public int[] InvertValues(int[] input)
        {
            if (input == null || input.Length == 0)
                return input;

            return input.Select(j => -j).ToArray();
        }

        public string Greet(string name)
        {
            return "Hello, " + name + " how are  you doing today?";
        }

        public int Past(int h, int m, int s)
        {
            var timeSpan = new TimeSpan(h, m, s);

            Convert.ToDouble(5);

            return (int)timeSpan.TotalMilliseconds;
            //return (h * 3600 + m * 60 + s) * 1000;
        }

        public double Index(int[] array, int n)
        {
            if (array.Length <= n)
                return -1;

            return Math.Pow(array[n], n);
        }




    }
}