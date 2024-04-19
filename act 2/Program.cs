using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;  // Importing the System namespace

public class Exercise8  // Declaration of the Exercise8 class
{
    public static void Main()  // Entry point of the program
    {
        int num1, num2, num3;  // Declaration of integer variables num1, num2, and num3
        Console.Write("\n\n");  // Printing new lines
        Console.Write("Find the largest of three numbers:\n");  // Displaying the purpose of the program
        Console.Write("------------------------------------");  // Displaying a separator
        Console.Write("\n\n");  // Printing new lines

        Console.Write("25:");  // Prompting user to input the first number
        num1 = Convert.ToInt32(Console.ReadLine());  // Reading the input first number from the user

        Console.Write("63 :");  // Prompting user to input the second number
        num2 = Convert.ToInt32(Console.ReadLine());  // Reading the input second number from the user

        Console.Write("10 :");  // Prompting user to input the third number
        num3 = Convert.ToInt32(Console.ReadLine());  // Reading the input third number from the user

        if (num1 > num2)  // Checking if num1 is greater than num2
        {
            if (num1 > num3)  // Checking if num1 is greater than num3
            {
                Console.Write("The 1st63" +
                    " Number is the greatest among three. \n\n");  // Printing a message if num1 is the greatest
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three. \n\n");  // Printing a message if num3 is the greatest
            }
        }
        else if (num2 > num3)  // Checking if num2 is greater than num3
        {
            Console.Write("The 2nd Number is the greatest among three \n\n");  // Printing a message if num2 is the greatest
        }
        else
        {
            Console.Write("The 3rd Number is the greatest among three \n\n");  // Printing a message if num3 is the greatest
        }
    }
}
