// See https://aka.ms/new-console-template for more information

// You are given a string S, in which one letter occurs twice. Every other letter occurs at most once.

// Write a function:

// class Solution { public string solution(string S); }

// which, given a string S, returns a single-character string: the letter that occurs twice.

// Examples:

// 1. Given S = "aba", the function should return "a".

// 2. Given S = "zz", the function should return "z".

// 3. Given S = "codility", the function should return "i".

// Assume that:

// the length of the string S is within the range [2..27];
// string S consists only of lowercase letters (a−z);
// all letters in S are distinct except one, which occurs twice.

// In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int flag = 0;

        while (true)
        {
            Console.WriteLine("Press 1 to run the solution, or 0 to exit:");
            flag = Convert.ToInt32(Console.ReadLine());

            if (flag == 1)
            {
                Console.WriteLine("Enter a word:");
                string word = Console.ReadLine();
                Console.WriteLine(solution(word));
            }
            else if (flag == 0)
            {
                Console.WriteLine("Exiting string solution...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 0.");
            }
        }
    }


    static string solution(string S)
    {

        foreach (char c in S)
        {
            if (S.IndexOf(c) != S.LastIndexOf(c))
            {
                return c.ToString();
            }
        }
        return "";
    }
}

