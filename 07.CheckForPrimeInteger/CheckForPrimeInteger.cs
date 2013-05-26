/* 07.Write an expression that checks if given 
 * positive integer number n (n ≤ 100) is prime. 
 * E.g. 37 is prime.
*/

using System;

class CheckForPrimeInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a number up to 100:");
        int checkNum = int.Parse(Console.ReadLine());

        // By definition, when the checking area has a max value(n<=100),
        // in code we can use area Math.Sqrt(100). 
        // In our case this means 10 (or n<=10). 
        // This will help to pick the numbers 2, 3, 5, 7. These numbers will be used in code.
        //
        // Create a boolean type that checks if the "checkNum" is dividable by 2; 3; 5; 7.
        // Use "logical and"(&&), because each condition must be fulfilled.
        bool checkDivision =  (checkNum % 2 > 0) && (checkNum % 3 > 0) && (checkNum % 5 > 0) && (checkNum % 7 > 0);

        // Create a boolean type that checks if the "checkNum" is one of the same numbers.
        bool checkEquation = (checkNum == 2) || (checkNum == 3) || (checkNum == 5) || (checkNum == 7);
        
        // Create a boolean type that combines the two previous conditions.
        // Use "logical or". If one of the conditions are true, 
        // than the number in "checkNum" is Prime.
        bool isPrime = checkDivision || checkEquation;

        if (isPrime == true)
        {
            Console.WriteLine("{0}! The {1} is a Prime number.", isPrime, checkNum);
        }
        else
        {
            Console.WriteLine("{0}", isPrime);
        }
    }
}