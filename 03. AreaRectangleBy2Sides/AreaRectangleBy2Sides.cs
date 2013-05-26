/* 03.Write an expression that calculates 
 * rectangle’s area by given width and height.
*/

using System;

class AreaRectangleBy2Sides
{
    static void Main()
    {
        Console.WriteLine("The program calculates rectangle's area by given width and height. \nEnter width:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("a = {0}", width);

        Console.WriteLine("Enter height:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("b = {0}\n", height);


        int rectArea = width * height;

        Console.WriteLine("S = " + rectArea);
    }
}