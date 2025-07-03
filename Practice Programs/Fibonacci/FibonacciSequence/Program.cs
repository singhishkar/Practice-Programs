// See https://aka.ms/new-console-template for more information

//Output Fibonacci Sequence

class Program
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        if (terms >= 0)
        {
            int a = 0, b = 1;
            for (int i = 0; i < terms; i++)
            {
                Console.Write(a + ", ");
                int nextVal = a + b;
                a = b;
                b = nextVal;
            }
        }
        else
        {
            Console.WriteLine("Please enter a non-negative number");
        }
    }
}
