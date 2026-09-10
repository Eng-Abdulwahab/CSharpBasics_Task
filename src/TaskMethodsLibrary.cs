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
            while (!int.TryParse(Console.ReadLine(), out num))
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

            string vowelChars = "aeiouAEIOU";
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
            for (int i = 1; i <= number; i++)
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

            for (int i = 1; i <= 12; i++)
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

            for (int i = 2; i < number; i++)
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
            while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber > 12 || monthNumber < 1)
            {
                Console.Write("Invalid input! Please enter a valid month (1-12): ");
            }

            int days = monthNumber switch
            {
                2 => 28, // February (Standard year)
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

            while (string.IsNullOrEmpty(originalString))
            {
                Console.Write("You didn't enter any thing! Enter a string: ");
                originalString = Console.ReadLine()!;
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

            if (number < 0)
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

            for (int i = Math.Max(2, start); i <= end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
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

            if (number == 0)
            {
                Console.WriteLine("Binary of [0]: 0");
                return;
            }

            int temp = number;
            string reversedBinary = string.Empty;
            string binary = string.Empty;

            while (temp > 0)
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

        public static void CheckCollinearPoints()
        {
            double x1, y1, x2, y2, x3, y3;

            // Point 1
            Console.Write("Enter x1: ");
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.Write("Invalid input! Enter a valid number for x1: ");
            }

            Console.Write("Enter y1: ");
            while (!double.TryParse(Console.ReadLine(), out y1))
            {
                Console.Write("Invalid input! Enter a valid number for y1: ");
            }

            // Point 2
            Console.Write("Enter x2: ");
            while (!double.TryParse(Console.ReadLine(), out x2))
            {
                Console.Write("Invalid input! Enter a valid number for x2: ");
            }

            Console.Write("Enter y2: ");
            while (!double.TryParse(Console.ReadLine(), out y2))
            {
                Console.Write("Invalid input! Enter a valid number for y2: ");
            }

            // Point 3
            Console.Write("Enter x3: ");
            while (!double.TryParse(Console.ReadLine(), out x3))
            {
                Console.Write("Invalid input! Enter a valid number for x3: ");
            }

            Console.Write("Enter y3: ");
            while (!double.TryParse(Console.ReadLine(), out y3))
            {
                Console.Write("Invalid input! Enter a valid number for y3: ");
            }

            // Cross-multiplication prevents division by zero [DivideByZeroException]
            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("\nThe points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("\nThe points do not lie on a single straight line.");
            }
        }

        public static void EvaluateWorkerEfficiency()
        {
            double hours;
            Console.Write("Enter time taken to complete the task (in hours): ");
            while (!double.TryParse(Console.ReadLine(), out hours) || hours < 0)
            {
                Console.Write("Invalid input! Please enter a valid positive duration in hours: ");
            }

            if (hours >= 2 && hours <= 3)
            {
                Console.WriteLine("Worker Efficiency: Highly efficient.");
            }
            else if (hours > 3 && hours <= 4)
            {
                Console.WriteLine("Worker Efficiency: Instructed to increase speed.");
            }
            else if (hours > 4 && hours <= 5)
            {
                Console.WriteLine("Worker Efficiency: Provided with training to enhance speed.");
            }
            else if (hours > 5)
            {
                Console.WriteLine("Worker Efficiency: Required to leave the company.");
            }
            else
            {
                Console.WriteLine("Worker completed task in less than 2 hours.");
            }
        }

        public static void PrintIdentityMatrix()
        {
            int n;
            Console.Write("Enter matrix size (n): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input! Please enter a positive integer for size (n): ");
            }

            Console.WriteLine($"\nIdentity Matrix of size {n}x{n}:\n");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static int SumOfArrayElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int[] MergeTwoArraysAndOrder(int[] arr1, int[] arr2)
        {
            int size = arr1.Length + arr2.Length;
            int[] arr3 = new int[size];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[i + arr1.Length] = arr2[i];
            }

            Array.Sort(arr3);
            return arr3;
        }

        public static void FrequencyOfEachElementInArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int frequency = 0;
                bool isAlreadyProcessed = false;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        frequency++;
                }

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isAlreadyProcessed = true;
                        break;
                    }
                }

                if (!isAlreadyProcessed)
                    Console.WriteLine($"Frequency of {arr[i]}: {frequency}");
            }
        }

        public static void GetMaxAndMinOfArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) return;

            int max = arr[0], min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];

                if (min > arr[i])
                    min = arr[i];
            }

            Console.WriteLine($"Max: {max}, Min: {min}");
        }

        public static void GetSecondLargestElementInArr(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                Console.WriteLine("Array must have at least two elements.");
                return;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }

            if (secondMax == int.MinValue)
            {
                Console.WriteLine("There is no second largest element (all elements are equal).");
            }
            else
            {
                Console.WriteLine($"Second Largest element: {secondMax}");
            }
        }

        public static void FindLongestDistanceBetweenEqualCells()
        {
            int size;
            Console.Write("Enter the size of the array (N): ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid size! Enter a positive integer: ");
            }

            int[] arr = new int[size];
            Console.WriteLine($"\nEnter {size} integer elements:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Cell [{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write($"Invalid input! Enter an integer for Cell [{i}]: ");
                }
            }

            int maxDistance = -1;
            int targetElement = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int currentDistance = j - i - 1;

                        if (currentDistance > maxDistance)
                        {
                            maxDistance = currentDistance;
                            targetElement = arr[i];
                        }

                        break;
                    }
                }
            }

            if (maxDistance != -1)
            {
                Console.WriteLine($"\nThe longest distance is for element ({targetElement}) with a distance of {maxDistance} cell/s.");
            }
            else
            {
                Console.WriteLine("\nNo equal elements found in the array.");
            }
        }

        public static void ReverseWords()
        {
            string sentence;
            Console.Write("Enter a string: ");
            while (string.IsNullOrEmpty(sentence = Console.ReadLine()!))
            {
                Console.Write("You must enter a string: ");
            }

            string[] arr = sentence.Split(' ');
            string reversed = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversed += arr[i];
                if (i > 0)
                    reversed += " ";
            }

            Console.WriteLine($"Reversed words: {reversed}");
        }

        public static void CopyTwoDimensionalArray()
        {
            int rows, cols;

            Console.Write("Enter number of rows: ");
            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            {
                Console.Write("Invalid input! Enter a positive integer for rows: ");
            }

            Console.Write("Enter number of columns: ");
            while (!int.TryParse(Console.ReadLine(), out cols) || cols <= 0)
            {
                Console.Write("Invalid input! Enter a positive integer for columns: ");
            }

            int[,] array1 = new int[rows, cols];
            int[,] array2 = new int[rows, cols];

            Console.WriteLine($"\nEnter elements for Array 1 ({rows}x{cols}):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out array1[i, j]))
                    {
                        Console.Write($"Invalid input! Enter an integer for [{i},{j}]: ");
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2[i, j] = array1[i, j];
                }
            }

            Console.WriteLine("\nElements of Second Array (Copied):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array2[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArrayInReverse()
        {
            int size;
            Console.Write("Enter the size of the array: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid size! Enter a positive integer: ");
            }

            int[] arr = new int[size];
            Console.WriteLine($"\nEnter {size} integer elements:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element [{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write($"Invalid input! Enter an integer for [{i}]: ");
                }
            }

            Console.WriteLine("\nArray in Reverse Order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void PassValueByVal(int x) => x = 100;

        public static void PassValueByRef(ref int x) => x = 100;

        public static void PassRefByVal(int[] arr)
        {
            if (arr != null && arr.Length > 0)
                arr[0] = 99;
            arr = new int[] { 5, 6, 7 };
        }

        public static void PassRefByRef(ref int[] arr)
        {
            arr = new int[] { 100, 200, 300 };
        }

        public static void CalculateSumAndSubtract()
        {
            int num1, num2, sum, sub;

            Console.Write("Enter first number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input! Enter an integer: ");
            }

            Console.Write("Enter second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input! Enter an integer: ");
            }

            sum = num1 + num2;
            sub = num1 - num2;

            Console.WriteLine($"\nSummation: {sum}");
            Console.WriteLine($"Subtraction: {sub}");
        }
        

        public static void SumAndSubtractWithOut(int a, int b, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
        }

        public static void CalculateSumOfDigits()
        {
            int number;
            Console.Write("Enter a number to calculate sum of digits: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Enter a valid integer: ");
            }

            int temp = Math.Abs(number);
            int sum = 0;

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static void MinMaxInArrayByRef(int[] arr, ref int min, ref int max)
        {
            if (arr == null || arr.Length == 0) return;

            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
        }

        public static long CalculateFactorial(int n)
        {
            if (n < 0) return -1; // Factorial for negative numbers doesn't exist
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string ChangeCharInString(string str, int position, char newChar)
        {
            if (string.IsNullOrEmpty(str) || position < 0 || position >= str.Length)
                return str;

            char[] charArray = str.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray);
        }
    }
}