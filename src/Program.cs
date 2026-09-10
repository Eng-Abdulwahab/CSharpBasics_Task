using System;

namespace CSharpBasics_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("        C# BASICS TASK - METHOD EXECUTIONS        ");
            Console.WriteLine("==================================================\n");

            #region Basics & Conversions (1 - 4)
            Console.WriteLine("--- [1] Get Number From User ---");
            TaskMethodsLibrary.GetNumberFromUser();

            Console.WriteLine("\n--- [2] Convert From String To Int ---");
            TaskMethodsLibrary.ConvertFromStringToInt("123");
            TaskMethodsLibrary.ConvertFromStringToInt("ABC");

            Console.WriteLine("\n--- [3] Perform Floating-Point Math ---");
            TaskMethodsLibrary.PerformFloatingPointMath(10.5, 4.3);

            Console.WriteLine("\n--- [4] Extract Substring ---");
            TaskMethodsLibrary.ExtractSubstring("Hello .NET Core API", 6, 4);
            #endregion

            #region Types & Memory Logic (5 - 7)
            Console.WriteLine("\n--- [5] Test Value Type ---");
            TaskMethodsLibrary.TestValueType();

            Console.WriteLine("\n--- [6] Test Reference Type ---");
            TaskMethodsLibrary.TestReferenceType();

            Console.WriteLine("\n--- [7] Concatenate Strings ---");
            TaskMethodsLibrary.ConcatenatedString("Backend ", "Developer");
            #endregion

            #region Financial & Mathematical Calculations (8 - 10)
            Console.WriteLine("\n--- [8] Calculate Simple Interest ---");
            double interest = TaskMethodsLibrary.CalculateSimpleInterest(10000, 5, 2);
            Console.WriteLine($"Simple Interest: {interest}");

            Console.WriteLine("\n--- [9] Calculate BMI ---");
            double bmi = TaskMethodsLibrary.CalculateBMI(75, 1.75);
            Console.WriteLine($"Calculated BMI: {bmi:F2}");

            Console.WriteLine("\n--- [10] Display Date Format ---");
            TaskMethodsLibrary.DisplayDateFormat();
            #endregion

            #region Conditional Statements & Logic (14 - 18)
            Console.WriteLine("\n--- [14] Check Divisibility By 3 and 4 ---");
            TaskMethodsLibrary.CheckDivisibilityBy3And4();

            Console.WriteLine("\n--- [15] Check Positive Or Negative ---");
            TaskMethodsLibrary.CheckPositiveOrNegative();

            Console.WriteLine("\n--- [16] Get Max And Min ---");
            TaskMethodsLibrary.GetMaxAndMin();

            Console.WriteLine("\n--- [17] Check Even Or Odd ---");
            TaskMethodsLibrary.CheckEvenOrOdd();

            Console.WriteLine("\n--- [18] Check Vowel ---");
            TaskMethodsLibrary.CheckVowel();
            #endregion

            #region Loops & Iterations (19 - 22)
            Console.WriteLine("\n--- [19] Display From One To N ---");
            TaskMethodsLibrary.DisplayFromOneToNumber();

            Console.WriteLine("\n--- [20] Display Multiplication Table ---");
            TaskMethodsLibrary.DisplayNumberMultiTable();

            Console.WriteLine("\n--- [21] Display Even To N ---");
            TaskMethodsLibrary.DisplayEvenToNumber();

            Console.WriteLine("\n--- [22] Calculate Power ---");
            TaskMethodsLibrary.CalculatePower(2, 5);
            #endregion

            #region Applied Problem Solving & Logic (23 - 32)
            Console.WriteLine("\n--- [23] Calculate Marks Statistics ---");
            TaskMethodsLibrary.CalculateMarksStatistics();

            Console.WriteLine("\n--- [24] Display Days In Month ---");
            TaskMethodsLibrary.DisplayDaysInMonth();

            Console.WriteLine("\n--- [25] Simple Calculator ---");
            TaskMethodsLibrary.SimpleCalculator();

            Console.WriteLine("\n--- [26] Reverse String ---");
            TaskMethodsLibrary.ReverseString();

            Console.WriteLine("\n--- [27] Reverse Int ---");
            TaskMethodsLibrary.ReverseInt();

            Console.WriteLine("\n--- [28] Prime Numbers From Range ---");
            TaskMethodsLibrary.PrimeNumbersFromRange();

            Console.WriteLine("\n--- [29] Convert Decimal To Binary ---");
            TaskMethodsLibrary.ConvertDecimalToBinary();

            Console.WriteLine("\n--- [30] Check Collinear Points ---");
            TaskMethodsLibrary.CheckCollinearPoints();

            Console.WriteLine("\n--- [31] Evaluate Worker Efficiency ---");
            TaskMethodsLibrary.EvaluateWorkerEfficiency();

            Console.WriteLine("\n--- [32] Print Identity Matrix ---");
            TaskMethodsLibrary.PrintIdentityMatrix();
            #endregion

            #region Arrays & Collection Algorithms (33 - 40)
            Console.WriteLine("\n--- [33] Sum Of Array Elements ---");
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Sum = {TaskMethodsLibrary.SumOfArrayElements(numbers)}");

            Console.WriteLine("\n--- [34] Merge Two Arrays And Order ---");
            int[] merged = TaskMethodsLibrary.MergeTwoArraysAndOrder(new[] { 5, 2, 8 }, new[] { 1, 9, 3 });
            Console.WriteLine($"Merged Sorted Array: {string.Join(", ", merged)}");

            Console.WriteLine("\n--- [35] Frequency Of Each Element ---");
            TaskMethodsLibrary.FrequencyOfEachElementInArr(new[] { 1, 2, 2, 3, 3, 3, 4 });

            Console.WriteLine("\n--- [36] Get Max And Min Of Array ---");
            TaskMethodsLibrary.GetMaxAndMinOfArray(numbers);

            Console.WriteLine("\n--- [37] Get Second Largest Element ---");
            TaskMethodsLibrary.GetSecondLargestElementInArr(numbers);

            Console.WriteLine("\n--- [38] Reverse Words ---");
            TaskMethodsLibrary.ReverseWords();

            Console.WriteLine("\n--- [39] Copy 2D Array ---");
            TaskMethodsLibrary.CopyTwoDimensionalArray();

            Console.WriteLine("\n--- [40] Print Array In Reverse ---");
            TaskMethodsLibrary.PrintArrayInReverse();
            #endregion

            #region Functions Section Executions
            Console.WriteLine("\n==================================================");
            Console.WriteLine("          FUNCTIONS SECTION EXECUTIONS            ");
            Console.WriteLine("==================================================");

            // Q1 Test
            Console.WriteLine("\n--- [Func Q1] Value Types (ByVal vs ByRef) ---");
            int val1 = 10, val2 = 10;
            TaskMethodsLibrary.PassValueByVal(val1);
            TaskMethodsLibrary.PassValueByRef(ref val2);
            Console.WriteLine($"ByVal Result: {val1} (Unchanged)");
            Console.WriteLine($"ByRef Result: {val2} (Modified to 100)");

            // Q2 Test
            Console.WriteLine("\n--- [Func Q2] Reference Types (ByVal) ---");
            int[] numbersArray = { 1, 2, 3 };
            TaskMethodsLibrary.PassRefByVal(numbersArray);
            Console.WriteLine($"Array[0] modified on Heap: {numbersArray[0]}");

            // Q3 Test
            Console.WriteLine("\n--- [Func Q3] Sum and Subtract with Out ---");
            TaskMethodsLibrary.SumAndSubtractWithOut(20, 10, out int sumResult, out int subResult);
            Console.WriteLine($"Sum (20 + 10) = {sumResult}");
            Console.WriteLine($"Subtract (20 - 10) = {subResult}");

            // Q4 Test
            Console.WriteLine("\n--- [Func Q4] Calculate Sum Of Digits ---");
            TaskMethodsLibrary.CalculateSumOfDigits();

            // Q5 Test
            Console.WriteLine("\n--- [Func Q5] Is Prime Number ---");
            int testNum = 17;
            bool isPrime = TaskMethodsLibrary.IsPrimeNumber(testNum);
            Console.WriteLine($"Is {testNum} prime? {isPrime}");

            // Q6 Test
            Console.WriteLine("\n--- [Func Q6] Min and Max In Array By Ref ---");
            int[] testArray = { 15, 3, 99, 42, 8 };
            int minVal = 0, maxVal = 0;
            TaskMethodsLibrary.MinMaxInArrayByRef(testArray, ref minVal, ref maxVal);
            Console.WriteLine($"Array: [{string.Join(", ", testArray)}]");
            Console.WriteLine($"Minimum = {minVal}, Maximum = {maxVal}");

            // Q7 Test
            Console.WriteLine("\n--- [Func Q7] Calculate Factorial ---");
            int factNum = 5;
            Console.WriteLine($"Factorial of {factNum} = {TaskMethodsLibrary.CalculateFactorial(factNum)}");

            // Q8 Test
            Console.WriteLine("\n--- [Func Q8] Change Char In String ---");
            string originalStr = "Task";
            string modifiedStr = TaskMethodsLibrary.ChangeCharInString(originalStr, 0, 'M');
            Console.WriteLine($"Original: {originalStr} -> Modified: {modifiedStr}");
            #endregion

            Console.WriteLine("\n==================================================");
            Console.WriteLine("          ALL TASKS EXECUTED SUCCESSFULLY         ");
            Console.WriteLine("==================================================");
        }
    }
}