/* 08.Write an expression that calculates trapezoid's area by 
 * given sides a and b, and height h.
*/

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("The programe calculates the area of a trapezoid \nby given two sides and a height.");

        Console.WriteLine("Enter first side:");
        decimal sideA = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter second side:");
        decimal sideB = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter height:");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal trapezArea = ((sideA + sideB) / 2) * height;

        Console.WriteLine("S = {0}\n", trapezArea);
    }
}