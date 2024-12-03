/*Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
 * Test Data :
 * Input a string : RADAR
 * Expected Output :
 * The string is Palindrome.*/
//Every substring is a palindrome. Try using trim?

using System;

namespace CCAD16_Assignment5_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a word to determine if it's a Palindrome:");
            string userInput = Console.ReadLine().Trim();
            Console.WriteLine($"Your word is: {userInput}");

            if (IsPalindrome(userInput))
            {
                Console.WriteLine("The string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is NOT a Palindrome.");
            }
        }

        static bool IsPalindrome(string input)
        {
            if (input.Length <= 1)
            {
                return true;
            }

            if (char.ToLower(input[0]) != char.ToLower(input[^1]))
            {
                return false;
            }         

            return IsPalindrome(input.Substring(1, input.Length - 2));
        }
    }
}
