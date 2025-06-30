// See https://aka.ms/new-console-template for more information

// FizzBuzz

// Write a function that does the following:

// console logs the numbers from 1 to n, where n is the integer the function takes as its parameter
// logs fizz instead of the number for multiples of 3
// logs buzz instead of the number for multiples of 5
// logs fizzbuzz for numbers that are multiples of both 3 and 5
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("FizzBuzz from 1 to " + num + ":");
        Fizzbuzz(num);
    }

    static int Fizzbuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        return n;
    }

}

