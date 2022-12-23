using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber, secondnumber;
            Console.WriteLine("Enter two numbers to get the perfect numbers");
            Console.WriteLine("Please Enter The First number : ");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Second number : ");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The perfect number from " + firstnumber + " and " + secondnumber + " Are : ");
            for (int i = firstnumber; i <= secondnumber; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine(+i);
            }
        }
    }
}
