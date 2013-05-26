/* 01.Write an expression that checks 
 * if given integer is odd or even.
*/

using System;

class OddOrEvenCheck
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number and press Enter:");
        
        int numToCheck = int.Parse(Console.ReadLine());
        int numChecked = numToCheck % 2;

        if (numChecked == 1)
        {
            Console.WriteLine("The number is: odd");
        }
        else 
        {
            Console.WriteLine("The number is: even");
        }
    }
}