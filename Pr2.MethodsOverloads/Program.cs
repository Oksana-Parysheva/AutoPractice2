using System;
using System.Linq;

namespace Pr2.MethodsOverloads
{
    class Program
    {
        public static double Maximum(params double[] numbers)
        {
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

            Console.WriteLine(Maximum() == null ? "No params" : $"Max number is {Maximum()}");
            Console.ReadLine();
        }
    }
}
