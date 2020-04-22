using System;

namespace Day_3_For_Loops
{
    class Program
    {
        /*Create a static method named FindMax that takes in two parameters: int num1 and int num2.
    The method should compare those two numbers and return the greater of the two.
    */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("FindMax is: " + FindMax(num1, num2) );
        }
        static int FindMax(int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }




        static void Main1(string[] args)
        {
            int all = 0;
            int second = 0;

            for (int i=1; i <= 100; i++)
            {
                // total odds and 44 and 90
                all += i;
                if (i==44 || i==90 || i%2==1)
                {
                    second+=i;
                }
            }
            Console.WriteLine($"all={all}");
            Console.WriteLine($"second={second}");
        }
    }
}
