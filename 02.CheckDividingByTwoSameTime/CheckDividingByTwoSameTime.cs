/* 02.Write a boolean expression that checks for given 
 * integer if it can be divided (without remainder)
 * by 7 and 5 in the same time.
*/

using System;

class CheckDividingByTwoSameTime
{
    static void Main()
    {
        Console.WriteLine("Type an integer number:");
        int numTyped = int.Parse(Console.ReadLine());
        int numBy7 = numTyped % 7;
        int numBy5 = numTyped % 5;

        if (numBy7 == 0 && numBy5 == 0)
        {
            Console.WriteLine("Yes, they are dividable by 7 and 5 at the same time.");
        }
        else
        {
            Console.WriteLine("No, they aren't!");
        }
    }
}