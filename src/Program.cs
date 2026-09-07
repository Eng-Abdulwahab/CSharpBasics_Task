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
            TaskMethodsLibrary.TestValueType(5, 8);
            Console.WriteLine("-------------------------------\n");
            // end


        }
    }
}
