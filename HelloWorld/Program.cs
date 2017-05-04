using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static string CreateMessage()
        {
            return "Hello World";
        }

        public static int CalculateSum(int a, int b)
        {
            int c;

            return a + b;
        }

        public static int CalculateDifference(int a, int b)
        {
            return a - b;
        }
    }
}
