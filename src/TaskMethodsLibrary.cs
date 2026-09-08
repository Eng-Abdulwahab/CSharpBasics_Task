using System;
using System.Text;


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
        public static void TestValueType()
        {
            int num1 = 4;
            int num2 = 7;
            num1 = num2;
            Console.WriteLine($"Before modifying: num1 = {num1}, num2 = {num2}");
            num2++;
            Console.WriteLine($"After adding 1 to num2: num1 = {num1}, num2 = {num2}");
            Console.WriteLine("So num1 does not change because integer is a Value Type.");
        }
        public static void TestReferenceType() // We Use StringBuilder as it is mutable.
        {
            StringBuilder sb1 = new StringBuilder("Hello");
            StringBuilder sb2 = sb1;
            Console.WriteLine($"Before modifying: StringBuilder1 = {sb1}, StringBuilder2 = {sb2}");
            sb2.Append(" world");
            Console.WriteLine($"After adding \" world\" to StringBuilder2: StringBuilder1 = {sb1}, StringBuilder2 = {sb2}");
            Console.WriteLine($"Conclusion: Both sb1 and sb2 now refer to the same object, so changing sb2 changed sb1 as well!");
        }
        public static void ConcatenatedString(string str1, string str2)
        {
            string concatenatedString = str1 + str2;
            Console.WriteLine(concatenatedString);
        }
        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
        public static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }
        public static void DisplayDateFormat()
        {
            Console.Write("Enter Day: ");
            if (!int.TryParse(Console.ReadLine(), out int day))
            {
                Console.WriteLine("Invalid day input!");
                return;
            }

            Console.Write("Enter Month: ");
            if (!int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("Invalid month input!");
                return;
            }

            Console.Write("Enter Year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid year input!");
                return;
            }

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");
        }
    }
}
