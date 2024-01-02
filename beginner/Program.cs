using System;

class Program
{
    static void Main()
    {
        // Prompt user for their name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Greet the user
        Console.WriteLine($"Hello, {userName}! Welcome to C# programming.");

        // Pause to keep console window open
        Console.ReadLine();
    }
}