// See https://aka.ms/new-console-template for more information
// Product of an array	

// Write a function solution that, given an array A of N integers (between −100 and 100), returns the sign (−1, 0, 1) of the product of all the numbers in the array multiplied together. Assume that N is between 1 and 1000.

// For example, given A = [1, −2, −3, 5], the function should return 1 (the multiplication equals 30).
// Given A = [1, 2, 3, −5] your function should return −1 (the multiplication equals −30).
// Given A = [1, 2, 0, −5] your function should return 0 (the multiplication equals 0).

//In other words, the values themselves are between -100 and 100, but there are 1 to 1000 integers.

class Program
{
    static void Main(string[] args)
    {
        int[] A = { 1, 2, 3, -5 };
        int[] B = { 1, 2, 0, -5 };

        int productA = Product(A);
        Console.WriteLine("Product of array A: " + productA);

        int productB = Product(B);
        Console.WriteLine("Product of array B: " + productB);
    }

    static int Product(int[] numbers)
    {
        int negativeNumCount = 0;

        foreach (int num in numbers)
        {
            if (num == 0)
                return 0;

            if (num < 0)
                negativeNumCount++;
        }

        if (negativeNumCount % 2 == 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}

