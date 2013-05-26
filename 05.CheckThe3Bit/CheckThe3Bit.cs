/* 05.Write a boolean expression for finding 
 * if the bit 3 (counting from 0) of a given integer 
 * is 1 or 0.
*/

using System;

class CheckThe3Bit
{
    static void Main()
    {
        Console.WriteLine("This program checks if the bit 3 (counting from 0)\nof a given integer is 1 or 0.\n");
        Console.WriteLine("Enter an integer number:");

        // Create an int type, in which to convert the typed string to int.
        int givenNum = int.Parse(Console.ReadLine());

        // Create a same type(int) parameter(tracedBit) and 
        // assign it with a value of the traced bit(3).
        int tracedBit = 3;

        // Assign a same type(int) new parameter(mask) with digit "1" and 
        // move it to left with the value of the traced bit(in this case from 1-st to 4-th position).
        // The value of "mask" will has "1" at the same place where the traced bit is,
        // the other digits from left and right will have "0"-s, like this "000000..1000".
        int mask = 1 << tracedBit;

        // Assign another new paremeter, with the sum of
        // typed integer(givenNum) and "mask", using "logical and"(&).
        // This expression will show if the traced bit is "0" or "1"(thanks to "&"),
        // the other digits from left and right will remain "0"-s.
        int givenPlusMask = givenNum & mask;

        // This expression will move the value of traced bit 
        // from 4-th position(because it's 3) to 1-st position,
        // the other positions will remain with "0"-s.
        int bit3 = givenPlusMask >> tracedBit;

        // Now, in "bit3", the value of traced bit is at 1-st position and can be printed.
        Console.WriteLine("\nThe 3-th bit in number {0} is:", givenNum);

        if (bit3 == 0)
        {
            Console.WriteLine("{0}\n", bit3);
        }
        else 
        {
            Console.WriteLine("{0}\n", bit3);
        }
    }
}