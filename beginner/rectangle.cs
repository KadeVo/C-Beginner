using System;

class Rectangle
{
    static void Main()
    {
        // Prompt user for length
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Prompt user for width
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate area
        double area = length * width;

      
        Console.WriteLine($"The area of the rectangle is: {area}");

   
        Console.ReadLine();
    }
}