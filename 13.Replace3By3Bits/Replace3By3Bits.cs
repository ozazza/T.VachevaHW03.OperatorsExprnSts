/* 13.Write a program that exchanges 
 * bits 3, 4 and 5 with 
 * bits 24, 25 and 26 of given 32-bit unsigned integer.
*/

using System;

class Replace3By3Bits
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int entrNum = int.Parse(Console.ReadLine());

        // I.The code for 3, 4 and 5-th bits:
        int p3To5 = 3;
        int mask345 = 7 << p3To5; // Representation of 7 in binary is 000..111. This mask will take down the values at bit's positions 3, 4 and 5.
        int bits3To5 = (entrNum & mask345) >> p3To5; // These are bits 3, 4 and 5, from right to left, at positions 1, 2 and 3.
        
        // II.The code for bits 24, 25 and 26-th:
        int p24To26 = 24;
        int mask24To26 = 7 << p24To26; // This mask will take down the values at bit's posotions 24, 25 and 26.
        int bits24To26 = (entrNum & mask24To26) >> p24To26; // These are the bits 24, 25 and 26, at positions 1, 2 and 3 (from right to left).

        //III.Replacing the bits

        // 1.Set bits positions 1, 2, 3 and 24, 25, 26, in the integer to 0:
        
        // 1.a. mask1 | mask2, the two masks sum;
        int maskTogether = mask345 | mask24To26;
        // 1.b. The integer & the ~(two masks). Now the 6 positions will be set to 0;
        int entrNumBitsTo0 = entrNum & (~maskTogether);

        // 2.Replacing the bits, creating new masks, and adding the new masks together:
        int newMask3To5 = bits24To26 << p3To5;
        int newMask24To26 = bits3To5 << p24To26;
        int newMasksTogether = newMask3To5 | newMask24To26;
        
        // 3.Add the bits at new positions in zeroed integer:
        int theNewInteger = entrNumBitsTo0 ^ newMasksTogether;

        //Printing the new integer:
        Console.WriteLine("The new integer is {0}", theNewInteger);

        Console.WriteLine("\nBinary explenation:\n");
        Console.WriteLine(Convert.ToString(entrNum, 2).PadLeft(32, '0') + " {0}" + " Your number in binary", entrNum);
        Console.WriteLine(Convert.ToString(7, 2).PadLeft(32, '0') + " Number 7 in binary");
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(mask345, 2).PadLeft(32, '0') + " mask345 in binary (7<<{0})", mask345);
        Console.WriteLine(Convert.ToString(mask24To26, 2).PadLeft(32, '0') + " mask24To26 in binary (7<<{0})", mask24To26);
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(bits3To5, 2).PadLeft(32, '0') + " bits3To5 at positions 1, 2 and 3");
        Console.WriteLine(Convert.ToString(bits24To26, 2).PadLeft(32, '0') + " bits24To26 at positions 1, 2 and 3");
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(maskTogether, 2).PadLeft(32, '0') + " the maskTogether");
        Console.WriteLine(Convert.ToString(entrNumBitsTo0, 2).PadLeft(32, '0') + " Zeroed positions in integer");
        Console.WriteLine(Convert.ToString(~maskTogether, 2).PadLeft(32, '0') + " ~(The two masks)");
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(newMask3To5, 2).PadLeft(32, '0') + " newMask3To5");
        Console.WriteLine(Convert.ToString(newMask24To26, 2).PadLeft(32, '0') + " newMask24To26");
        Console.WriteLine(Convert.ToString(newMasksTogether, 2).PadLeft(32, '0') + " newMasksTogether");
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(theNewInteger, 2).PadLeft(32, '0') + " The new integer\n");
    }
}