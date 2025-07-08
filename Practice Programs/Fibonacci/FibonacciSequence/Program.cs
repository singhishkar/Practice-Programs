// // See https://aka.ms/new-console-template for more information

// //Output Fibonacci Sequence

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int numOfTerms = Convert.ToInt32(Console.ReadLine());

        if (numOfTerms < 0)
        {
            Console.WriteLine("Please enter a non-negative number.");
            return;
        }

        fibonacciOutput(numOfTerms);
    }

    static void fibonacciOutput(int termNums)
    {
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < termNums; i++)
        {
            Console.Write(fibonacciCalc(i));

            if (i < termNums - 1)
                Console.Write(", ");
        }
    }

    static int fibonacciCalc(int position)
    {
        if (position == 0) return 0;
        if (position == 1) return 1;

        return fibonacciCalc(position - 1) + fibonacciCalc(position - 2);
    }
}
