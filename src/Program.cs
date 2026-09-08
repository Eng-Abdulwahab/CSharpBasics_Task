namespace CSharpBasics_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 
            Console.WriteLine("1)\n-------------------------------");
            TaskMethodsLibrary.GetNumberFromUser();
            Console.WriteLine("-------------------------------\n");
            // end

            // 2
            Console.WriteLine("2)\n-------------------------------");
            TaskMethodsLibrary.ConvertFromStringToInt("hello"); // will throw exception but i used Exception Handling.
            Console.WriteLine("-------------------------------\n");
            // end

            // 3
            Console.WriteLine("3)\n-------------------------------");
            TaskMethodsLibrary.PerformFloatingPointMath(0.1, 0.3);
            Console.WriteLine("-------------------------------\n");
            // end

            // 4
            Console.WriteLine("4)\n-------------------------------");
            TaskMethodsLibrary.ExtractSubstring("Hello World!", 0, 9);
            Console.WriteLine("-------------------------------\n");
            // end

            // 5
            Console.WriteLine("5)\n-------------------------------");       
            TaskMethodsLibrary.TestValueType();
            Console.WriteLine("-------------------------------\n");
            // end

            // 6
            Console.WriteLine("6)\n-------------------------------");
            TaskMethodsLibrary.TestReferenceType();
            Console.WriteLine("-------------------------------\n");
            // end

            // 7
            Console.WriteLine("7)\n-------------------------------");
            TaskMethodsLibrary.ConcatenatedString("Hello ", "World!");
            Console.WriteLine("-------------------------------\n");
            // end

            // 8
            Console.WriteLine("8)\n-------------------------------");
            double interest = TaskMethodsLibrary.CalculateSimpleInterest(10000, 5, 2);
            Console.WriteLine($"Simple Interest = {interest}");
            Console.WriteLine("-------------------------------\n");
            // end

            // 9
            Console.WriteLine("9)\n-------------------------------");
            double bmi = TaskMethodsLibrary.CalculateBMI(75, 1.75);
            Console.WriteLine($"BMI = {bmi:F2}");
            Console.WriteLine("-------------------------------\n");
            // end

            // 10
            Console.WriteLine("10)\n-------------------------------");
            TaskMethodsLibrary.DisplayDateFormat();
            Console.WriteLine("-------------------------------\n");
            // end


        }
    }
}
