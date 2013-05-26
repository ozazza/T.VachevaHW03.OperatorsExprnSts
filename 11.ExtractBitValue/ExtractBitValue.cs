/* 11.Write an expression that extracts from a given
 * integer i the value of a given bit number b. 
 * Example: i=5; b=2  value=1.
*/

using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.WriteLine("This program checks if the bit, at any position \nin an integer number, has a value of 1.\n");

        Console.WriteLine("Enter an integer number:");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the positon, that you need to check:");
        int p = int.Parse(Console.ReadLine());

        // Use as mask the number "1", moved "p" times to left
        // in order, "1" to be set at the same position as the typed position.
        int mask = 1 << p;

        // Add up the mask and checked number using "logical and"(&).
        // If the digit in the number is 0, added to 1, will give 0.
        // If the digit is 1, added to 1, will give 1.
        int vPlusMask = v & mask;

        // Finally, the digits in sum, must be moved with "p" position, back to right,
        // in order to move the position of needed bit to first place.
        int theBitValueIs = vPlusMask >> p;

        // The only difference from exercise 10, is after this line.
        Console.WriteLine("i = {0}; b = {1} -> value = {2}\n", v, p, theBitValueIs);
    }
}