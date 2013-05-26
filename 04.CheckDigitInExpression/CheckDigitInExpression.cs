/*Write an expression that checks for given integer 
 * if its third digit (right-to-left) is 7. 
 * E. g. 1732  true.
 */

using System;

class CheckDigitInExpression
{
    static void Main()
    {
        int num = 1732;
        bool checkResult = (num / 100) % 10 == 7;

        if (checkResult == true)
        {
            Console.WriteLine(checkResult);
        }
        else
        {
            Console.WriteLine((checkResult));
        }
    }
}