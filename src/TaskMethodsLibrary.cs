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
            int day, month, year;
            Console.Write("Enter Day: ");
            while (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.Write("Invalid day input! enter a valid day: ");                
            }

            Console.Write("Enter Month: ");
            while (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.Write("Invalid month input! enter a valid month: ");
            }

            Console.Write("Enter Year: ");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Invalid year input! enter a valid year: ");
            }

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");
        }

        public static void CheckDivisibilityBy3And4()
        {
            int number;
            Console.Write("Enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static void CheckPositiveOrNegative()
        {
            Console.Write("Enter an integer: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }

        public static void GetMaxAndMin()
        {
            int num1, num2, num3;
            Console.Write("Enter num1: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            Console.Write("Enter num2: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }
            

            Console.Write("Enter num3: ");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine($"Max: {max}, Min: {min}");
        }

        public static void CheckEvenOrOdd()
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void CheckVowel()
        {
            char character;
            Console.WriteLine("Enter a character: ");
            while (!char.TryParse(Console.ReadLine(), out character))
            {
                Console.Write("Invalid input! Please enter a valid char: ");
            }

            string vowelChars = "aeiou";
            if (vowelChars.Contains(character))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }

        public static void DisplayFromOneToNumber() 
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }
            for(int i = 1; i <= number; i++)
            {
                Console.Write($"{i}");
                if (i != number)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        public static void DisplayNumberMultiTable() 
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            Console.WriteLine($"[ Multiplication_Table of ({number}) ]");

            for(int i = 1; i <= 12; i++)
            {
                Console.Write($"{number * i} ");
            }
            Console.WriteLine();
        }

        public static void DisplayEvenToNumber()
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            for(int i = 2; i < number; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void CalculatePower(int baseNum, int exponent)
        {
            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine($"Output: {result}");
        }

        public static void CalculateMarksStatistics()
        {
            Console.WriteLine("Enter Marks of five subjects: ");

            int total = 0;
            int count = 5;
            int mark;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Subject {i}: ");
                while (!int.TryParse(Console.ReadLine(), out mark))
                {
                    Console.Write("Invalid input! Please enter a valid integer mark: ");
                }
                total += mark;
            }

            double average = (double)total / count;
            double percentage = average;

            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks = {average:F0}");
            Console.WriteLine($"Percentage = {percentage:F0}%");
        }

        public static void DisplayDaysInMonth()
        {
            int monthNumber;
            Console.WriteLine("Enter month number: ");
            while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber > 12 || monthNumber < 1 )
            {
                Console.Write("Invalid input! Please enter a valid month (1-12): ");
            }  

            int days = monthNumber switch
            {
                2 => 28, // February (Standard year assumption)
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };

            Console.WriteLine($"Days in Month: {days}");
        }

        public static void SimpleCalculator()
        {
            double num1, num2;
            Console.Write("Enter first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid first number! Enter a valid number: ");
            }

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid second number! Enter a valid number: ");
            }

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    else
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        }

        public static void ReverseString()
        {
            Console.WriteLine("Enter a string: ");
            string originalString = Console.ReadLine()!;

            while(string.IsNullOrEmpty(originalString))
            {
                Console.Write("You didn't enter any thing! Enter a string: ");
            }

            string reversedString = string.Empty;

            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reversedString += originalString[i];
            }

            Console.WriteLine($"Reversed String: {reversedString}");
        }

        public static void ReverseInt()
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            int reversedNumber = 0;
            int temp = Math.Abs(number);
           
            while (temp > 0)
            {
                int remainder = temp % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                temp /= 10;
            }

            if(number < 0)
            {
                reversedNumber = -reversedNumber;
            }

            Console.WriteLine($"Reversed Integer: {reversedNumber}");
        }

        public static void PrimeNumbersFromRange()
        {
            int start, end;
            Console.Write("Input starting number of range: ");
            while (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }
            
            Console.Write("Input ending number of range: ");
            while (!int.TryParse(Console.ReadLine(), out end))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }            

            for(int i = 2; i < end; i++)
            {
                bool isPrime= true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0 && i != j)
                        isPrime = false;                    
                }

                if(isPrime)
                    Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        public static void ConvertDecimalToBinary()
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }

            int temp = number;
            string reversedBinary = string.Empty;
            string binary = string.Empty;

            while(temp > 0)
            {

                if (temp % 2 == 0)
                    reversedBinary += "0";
                else 
                    reversedBinary += "1";

                temp /= 2;
            }
            

            for (int i = reversedBinary.Length - 1; i >= 0; i--)
            {
                binary += reversedBinary[i];
            }

            Console.WriteLine($"Binary of [{number}]: {binary}");
        }
    }
}
