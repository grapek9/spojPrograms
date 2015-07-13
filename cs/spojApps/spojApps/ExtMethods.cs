using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class ExtMethods
    {
        public static int pow(this int arg) { return arg * arg; }
        public static int pow(this int arg, int power) { return (int)Math.Pow(arg, power); }
        public static double pow(this double arg) { return arg * arg; }
        public static double pow(this double arg, int power) { return Math.Pow(arg, power); }
        public static string[] split(this string text)
        {
            string[] splitedArray = text.Split(' ',',','.',';');
            return splitedArray;
        }
        public static int wordcounter(this string text)
        {
            string[] splitedArray = text.Split(' ', ',', '.', ';');
            return splitedArray.Length;
        }
        public static int[] multiply(this int[] array)
        {
            int i = 0;
            foreach (int iterator in array)
            {
                array[i] = iterator * 2;
                i++;
            }
            return array;
        }
        public static int[] multiply(this int[] array,int value)
        {
            int i = 0;
            foreach (int iterator in array)
            {
                array[i] = iterator * value;
                i++;
            }
            return array;
        }
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
          foreach(T item in collection)
             action(item);
        }
    }
}
