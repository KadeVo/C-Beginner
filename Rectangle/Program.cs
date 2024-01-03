using System;

class Rectangle
{
    static void Main()
    {
        // Prompt for user's name
        Console.Write("What is your name? "); 
        string name = Console.ReadLine();  // Read the name and stores it in a variable
        //Another type is char which is used for singular characters eg: char symbol = '@' 
        // char also has to be in single quotes.


        // Prompt for length and width
        Console.Write("Enter the length of the rectangle in cm: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle in cm: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate area
        double area = length * width;

        // Display the area
        Console.WriteLine($"Hello, {name}! The area of the rectangle is: {area} cm²");

        // Pause to keep the console window open
        Console.ReadLine();
    }
}