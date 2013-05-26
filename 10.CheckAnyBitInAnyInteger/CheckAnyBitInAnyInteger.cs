/* 10.Write a boolean expression that returns 
 * if the bit at position p (counting from 0) 
 * in a given integer number v has value of 1. 
 * Example: v=5; p=1  false
*/

using System;

class CheckAnyBitInAnyInteger
{
    static void Main()
    {
        Console.WriteLine("This program checks if the bit, at any position \nin an integer number, has a value of 1.\n");

        Console.WriteLine("Enter an integer number:");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the positon, that you need to check:");
        int p = int.Parse(Console.ReadLine());

        // Use as mask the number "1", moved "p" times to left,
        // in order "1" to be set at the same position as the typed position.
        int mask = 1 << p;

        // Add up the mask to checked number using "logical and"(&).
        // If the digit in the number is 0, added to 1, will give 0.
        // If the digit is 1, added to 1, will give 1.
        int vPlusMask = v & mask;

        // Finally, the digits in sum must be moved with "p" position, back to right,
        // in order to move the position of needed bit to first place.
        int theBitValueIs = vPlusMask >> p;

        if (theBitValueIs == 1)
        {
            Console.WriteLine("v = {0}; p = {1}; value of the bit = {2}; -> true\n", v, p, theBitValueIs);
        }
        else
        {
            Console.WriteLine("v = {0}; p = {1}; value of the bit = {2}; -> false\n", v, p, theBitValueIs);
        }
    }
}