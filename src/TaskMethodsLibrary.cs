using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpBasics_Task
{
    internal class TaskMethodsLibrary
    {
        public static void GetNumberFromUser()
        {
            Console.Write("Enter a number: ");
            int num;
            while(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }            
            Console.WriteLine($"You entered: {num}");
        }
        public static void ConvertFromStringToInt(string invalidString)
        {
            if (int.TryParse(invalidString, out int result))
            {
                Console.WriteLine($"Success: {result}");
            }
            else
            {
                Console.WriteLine("Conversion failed safely without throwing an exception.");
            }
        }
        public static void PerformFloatingPointMath(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
        public static void ExtractSubstring(string str, int startIndex, int length)
        {
            string result = str.Substring(startIndex, length);

            Console.WriteLine($"Original String: \"{str}\"");
            Console.WriteLine($"Extracted Substring: \"{result}\"");
        }
        public static void TestValueType(int num1, int num2)
        {            
            num1 = num2;
            Console.WriteLine($"Before modifying: num1 = {num1}, num2 = {num2}");
            num2++;
            Console.WriteLine($"After adding 1 to num2: num1 = {num1}, num2 = {num2}");
            Console.WriteLine("So num1 does not change because integer is a Value Type.");
        }
    }
}
