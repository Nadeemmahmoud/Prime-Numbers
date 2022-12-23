using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum, secondnum, result = 0;
             Console.WriteLine("Enter two Numbers to get the prime numbers Between Them");
            Console.Write("Please Enter The First Number : ");
            firstnum = int.Parse(Console.ReadLine());
            Console.Write("Please Enter The Second Number : ");
            secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between " + firstnum + " and " + secondnum + " Are : ");
            for (int i = 2; i < secondnum; i++)
            {
                for (int j = 1; j < secondnum; j++)
                {
                    if (i % j == 0)
                    {
                        result++;
                    }
                }
                if (result == 2)
                {
                    Console.WriteLine(i);
                }
                result = 0;
            }
        }
    }
}

