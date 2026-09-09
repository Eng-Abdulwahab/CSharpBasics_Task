namespace CSharpBasics_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            // 1
            Console.WriteLine("1) [Print User Input Number]\n-------------------------------");
            TaskMethodsLibrary.GetNumberFromUser();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 2
            Console.WriteLine("2) [Safe String-to-Int Conversion]\n-------------------------------");
            TaskMethodsLibrary.ConvertFromStringToInt("hello"); // Handled safely using int.TryParse without exceptions
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 3
            Console.WriteLine("3) [Floating-Point Math Operation]\n-------------------------------");
            TaskMethodsLibrary.PerformFloatingPointMath(0.1, 0.3);
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 4
            Console.WriteLine("4) [Extract Substring]\n-------------------------------");
            TaskMethodsLibrary.ExtractSubstring("Hello World!", 0, 9);
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 5
            Console.WriteLine("5) [Value Type Modification Test]\n-------------------------------");
            TaskMethodsLibrary.TestValueType();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 6
            Console.WriteLine("6) [Reference Type Modification Test]\n-------------------------------");
            TaskMethodsLibrary.TestReferenceType();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 7
            Console.WriteLine("7) [String Concatenation]\n-------------------------------");
            TaskMethodsLibrary.ConcatenatedString("Hello ", "World!");
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 8
            Console.WriteLine("8) [Calculate Simple Interest]\n-------------------------------");
            double interest = TaskMethodsLibrary.CalculateSimpleInterest(10000, 5, 2);
            Console.WriteLine($"Simple Interest = {interest}");
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 9
            Console.WriteLine("9) [Calculate Body Mass Index (BMI)]\n-------------------------------");
            double bmi = TaskMethodsLibrary.CalculateBMI(75, 1.75);
            Console.WriteLine($"BMI = {bmi:F2}");
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 10
            Console.WriteLine("10) [Display Date Formats]\n-------------------------------");
            TaskMethodsLibrary.DisplayDateFormat();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 11
            Console.WriteLine("11) [MCQ: DateTime Formatting]\n-------------------------------");
            Console.WriteLine("Answer: (c) The event is on 06/14/2024.");
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 12
            Console.WriteLine("12) [MCQ: Boolean Conversion Logic]\n-------------------------------");
            Console.WriteLine("Answer: (f) A value 1 will be assigned to d.");
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 13
            Console.WriteLine("13) [MCQ: Integer Division & Modulus]\n-------------------------------");
            Console.WriteLine("Answer: (d) (6, 1).");
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 14
            Console.WriteLine("14) [Check Divisibility by 3 and 4]\n-------------------------------");
            TaskMethodsLibrary.CheckDivisibilityBy3And4();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 15
            Console.WriteLine("15) [Check Positive or Negative]\n-------------------------------");
            TaskMethodsLibrary.CheckPositiveOrNegative();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 16
            Console.WriteLine("16) [Find Max and Min of 3 Numbers]\n-------------------------------");
            TaskMethodsLibrary.GetMaxAndMin();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 17
            Console.WriteLine("17) [Check Even or Odd]\n-------------------------------");
            TaskMethodsLibrary.CheckEvenOrOdd();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 18
            Console.WriteLine("18) [Check Vowel or Consonant Character]\n-------------------------------");
            TaskMethodsLibrary.CheckVowel();
            Console.WriteLine("-------------------------------\n");
            // end 

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 19
            Console.WriteLine("19) [Print Numbers Range from 1 to N]\n-------------------------------");
            TaskMethodsLibrary.DisplayFromOneToNumber();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 20
            Console.WriteLine("20) [Print Multiplication Table up to 12]\n-------------------------------");
            TaskMethodsLibrary.DisplayNumberMultiTable();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 21
            Console.WriteLine("21) [Print Even Numbers between 1 and N]\n-------------------------------");
            TaskMethodsLibrary.DisplayEvenToNumber();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 22
            Console.WriteLine("22) [Calculate Power]\n-------------------------------");
            TaskMethodsLibrary.CalculatePower(2, 5);
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 23
            Console.WriteLine("23) [CalculateMarksStatistics]\n-------------------------------");
            TaskMethodsLibrary.CalculateMarksStatistics();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();
            
            // 24
            Console.WriteLine("24) [Display Number of Days in Month]\n-------------------------------");
            TaskMethodsLibrary.DisplayDaysInMonth();            
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 25
            Console.WriteLine("25) [Simple Calculator]\n-------------------------------");
            TaskMethodsLibrary.SimpleCalculator();            
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 26
            Console.WriteLine("26) [Reversed String]\n-------------------------------");
            TaskMethodsLibrary.ReverseString();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 27
            Console.WriteLine("27) [Reversed Integer]\n-------------------------------");
            TaskMethodsLibrary.ReverseInt();
            Console.WriteLine("-------------------------------\n");
            // end 

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 28
            Console.WriteLine("28) [Prime Numbers From Range]\n-------------------------------");
            TaskMethodsLibrary.PrimeNumbersFromRange();
            Console.WriteLine("-------------------------------\n");
            // end 

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 29
            Console.WriteLine("29) [Convert Decimal To Binary]\n-------------------------------");
            TaskMethodsLibrary.ConvertDecimalToBinary();
            Console.WriteLine("-------------------------------\n");
            // end
            
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 30
            Console.WriteLine("30) [Check if Three Points Lie on a Straight Line]\n-------------------------------");
            TaskMethodsLibrary.CheckCollinearPoints();
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 31
            Console.WriteLine("31) [Evaluate Worker Efficiency]\n-------------------------------");
            TaskMethodsLibrary.EvaluateWorkerEfficiency();            
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 32
            Console.WriteLine("32) [Print Identity Matrix]\n-------------------------------");
            TaskMethodsLibrary.PrintIdentityMatrix();            
            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 33
            Console.WriteLine("33) [Sum of Array Elements]\n-------------------------------");

            int[] numbers33 = { 10, 20, 30, 40, 50 };

            int totalSum = TaskMethodsLibrary.SumOfArrayElements(numbers33);

            Console.WriteLine($"Array elements: {string.Join(", ", numbers33)}");
            Console.WriteLine($"Sum of array elements = {totalSum}");

            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 34
            Console.WriteLine("34) [Merge and Sort Two Unsorted Arrays]\n-------------------------------");

            int[] array1 = { 9, 2, 5, 1 };
            int[] array2 = { 8, 3, 7, 4 };

            int[] result = TaskMethodsLibrary.MergeTwoArraysAndOrder(array1, array2);

            Console.WriteLine($"Array 1: {string.Join(", ", array1)}");
            Console.WriteLine($"Array 2: {string.Join(", ", array2)}");
            Console.WriteLine($"Merged & Sorted Array: {string.Join(", ", result)}");

            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 35
            Console.WriteLine("35) [Frequency of Each Element in Array]\n-------------------------------");

            int[] numbers35 = { 5, 2, 8, 5, 2, 5, 9, 8 };

            Console.WriteLine($"Array elements: {string.Join(", ", numbers35)}\n");

            TaskMethodsLibrary.FrequencyOfEachElementInArr(numbers35);

            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 36
            Console.WriteLine("36) [Max and Min in Array]\n-------------------------------");

            int[] numbers36 = { 45, 12, 89, 3, 27, -5, 64 };

            Console.WriteLine($"Array elements: {string.Join(", ", numbers36)}\n");

            TaskMethodsLibrary.GetMaxAndMinOfArray(numbers36);

            Console.WriteLine("-------------------------------\n");
            // end

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();

            // 37
            Console.WriteLine("37) [Find Second Largest Element in Array]\n-------------------------------");

            int[] numbers37 = { 10, 20, 4, 45, 99, 99, 35 };

            Console.WriteLine($"Array elements: {string.Join(", ", numbers37)}\n");

            TaskMethodsLibrary.GetSecondLargestElementInArr(numbers37);

            Console.WriteLine("-------------------------------\n");
            // end
        }
    }
}
