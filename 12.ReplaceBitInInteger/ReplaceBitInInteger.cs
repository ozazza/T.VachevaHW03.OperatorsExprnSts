/* 12.We are given 
 * integer number n,
 * value v (v=0 or 1)
 * and a position p.
 * Write a sequence of operators that
 * modifies n to hold the value v at the position p from
 * the binary representation of n.
	    Example:
 *      n = 5 (00000101), p=3, v=1  13 (00001101)
	    n = 5 (00000101), p=2, v=0  1 (00000001)
*/

using System;

class ReplaceBitInInteger
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int nNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the bit's value (0 or 1):");
        int vValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the position (0 to 31):");
        int pPosition = int.Parse(Console.ReadLine());

        int mask = 1 << pPosition;

        if (vValue == 0)
        {
            int newNum = (~mask) & nNum;
            string newNumBinary = Convert.ToString(newNum, 2).PadLeft(32, '0');
            string nBinary = Convert.ToString(nNum, 2).PadLeft(32, '0');
            Console.WriteLine("n = {0} ({1}), p = {2}, v ={3} \n--> {4} ({5})\n", nNum, nBinary, pPosition, vValue, newNum, newNumBinary);
            Console.WriteLine(Convert.ToString(nNum, 2).PadLeft(32, '0') + " Your number");
            Console.WriteLine(Convert.ToString((~mask), 2).PadLeft(32, '0') + " Mask (inverted)");
            Console.WriteLine(newNumBinary + " The new number");
        }
        else
        {
            int newNum = mask | nNum;
            string newNumBinary = Convert.ToString(newNum, 2).PadLeft(32, '0');
            string nBinary = Convert.ToString(nNum, 2).PadLeft(32, '0');
            Console.WriteLine("n = {0} ({1}), p = {2}, v ={3} \n--> {4} ({5})\n", nNum, nBinary, pPosition, vValue, newNum, newNumBinary);
            Console.WriteLine(Convert.ToString(nNum, 2).PadLeft(32, '0') + " Your number");
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0') + " Mask");
            Console.WriteLine(newNumBinary + " The new number");
        }
    }
}