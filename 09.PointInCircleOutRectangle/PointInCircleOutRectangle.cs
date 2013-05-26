/* 09.Write an expression that checks for given 
 * point (x, y) if it is within the circle K( (1,1), 3) and 
 * out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        
        Console.WriteLine("Enter the point's \"x\" ordinate:");
        decimal axisPointX = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the point's \"y\" ordinate:");
        decimal axisPointY = decimal.Parse(Console.ReadLine());

        // Here are the coordinates of the circle:
        decimal axisCircleA = 1m;
        decimal axisCircleB = 1m;
        decimal radius = 3m;
        
        // Here is used the equation of circle: (x-a)^2 + (y-b)^2 = r^2; 
        // or x2 + y2 – 2ax – 2by + a2 + b2 – r2 = 0.
        // if this equation is <=0, than the point is within the circle.
        decimal circleEquality = (axisPointX * axisPointX) + (axisPointY * axisPointY) 
            - (2 * axisCircleA * axisPointX) - (2 * axisCircleB * axisPointY)
            + (axisCircleA * axisCircleA) + (axisCircleB * axisCircleB) 
            - (radius * radius);
        
        // After calculations the rectangle's points are:
        // A(1,-1) top-left;        B(7,-1) top-right;
        // D(1,-3) bottom-left;     C(7,-3) bottom-right;

        decimal rectangleX1 = 1m;
        decimal rectangleX2 = 7m;
        decimal rectangleY1 = -1m;
        decimal rectangleY2 = -3m;

        // Parameters for the point(x,y) if it's in the rectangle:
        bool inRectangleX = (axisPointX >= rectangleX1) && (axisPointX <= rectangleX2); // x >= 1, x <= 7;
        bool inRectangleY = (axisPointY <= rectangleY1) && (axisPointY >= rectangleY2); // y <= -1, y >= -3

        // If the point(x,y) is in the rectanangle, than both boolean types must be true.
        bool pointInRectangle = inRectangleX && inRectangleY;

        // If the point(x,y) is in the circle, than the equality of circle must be less or equal to zero.
        bool pointInCircle = circleEquality <= 0m;

        if (pointInRectangle == true)
        {
            Console.WriteLine("\nThe point ({0}, {1}) is within the rectangle ", axisPointX, axisPointY);
        }
        else
        {
            Console.WriteLine("\nThe point ({0}, {1}) is out of the rectangle ", axisPointX, axisPointY);
        }

        if (pointInCircle == true)
        {
            Console.WriteLine("and within the circle.\n");
        }
        else 
        {
            Console.WriteLine("and out of the circle.\n");
        }

    }
}