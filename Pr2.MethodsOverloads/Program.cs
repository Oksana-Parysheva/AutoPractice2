using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr2.MethodsOverloads
{
    static class Program
    {
        static T FindMax<T>(IEnumerable<T> en)
            where T : IComparable
        {
            bool firstTime = true;
            T max = default(T);
            foreach (var e in en)
            {
                if (firstTime || max.CompareTo(e) < 0)
                {
                    max = e;
                    firstTime = false;
                }
            }

            return max;
        }

        static T FindMaxExt<T>(this IEnumerable<T> en)
            where T : IComparable
        {
            bool firstTime = true;
            T max = default(T);
            foreach (var e in en)
            {
                if (firstTime || max.CompareTo(e) < 0)
                {
                    max = e;
                    firstTime = false;
                }
            }

            return max;
        }

        public static double Maximum(params double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                max = Maximum(max, numbers[i]);
                var temp = i;
            }

            return numbers.Max();
        }

        public static double MaximumNew(params double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                max = Maximum(max, numbers[i]);
            }
            return numbers.Max();
        }

        public static double Maximum(double number1, double number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public static string Maximum(string number1, string number2)
        {
            if (number1.Length > number2.Length)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter amount of numbers: ");
            int count = Convert.ToInt32(Console.ReadLine());

            double[] arrayNumbers = new double[count];
            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter {0} number: ", i);
                arrayNumbers[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Max number is {Maximum(arrayNumbers)}");
            Console.WriteLine($"Max number is {Maximum("str1", "str2")}");
            Console.WriteLine($"Generic :: Max number is {FindMax(new[] { "str1", "str2", "str0", "str4" })}");
            Console.WriteLine($"Generic :: Max number is {FindMax(arrayNumbers)}");
            Console.WriteLine($"Extention :: Max number is {new[] { "str1", "str2", "str0", "str4" }.FindMaxExt()}");
            Console.WriteLine($"Extention :: Max number is {arrayNumbers.FindMaxExt()}");

            Console.WriteLine(Maximum() == null ? "No params" : $"Max number is {Maximum()}");
            Console.ReadLine();
        }
    }
}
