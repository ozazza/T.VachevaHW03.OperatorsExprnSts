/* 06.Write an expression that checks if 
 * a given point (x,  y) is within a circle K(O, 5).
*/

using System;

class CheckIfPointIsInCircle
{
    static void Main()
    {
        Console.WriteLine("This program checks if given point (x, y) is within circle K(O, 5).");

        Console.WriteLine("Enter the \"x\" ordinate:");
        decimal axisX = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the \"y\" ordinate:");
        decimal axisY = decimal.Parse(Console.ReadLine());

        decimal radius = 5m;

        // Here is used the equation of circle: (x-a)^2 + (y-b)^2 = r^2; 
        // and when a=b=0 then: x^2 + y^2 = r^2.
        if ((axisX * axisX) + (axisY * axisY) - (radius * radius) <= 0)
        {
            Console.WriteLine("The point ({0}, {1}) is within the circle.\n", axisX, axisY);
        }
        else 
        {
            Console.WriteLine("The point is out of the circle.\n");
        }
    }
}