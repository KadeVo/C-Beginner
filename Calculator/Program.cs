using System;

class Rectangle
{
    static void Main()
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        
        Console.WriteLine("Enter your first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter your second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an symbol: ");
        Console.WriteLine(("+ : Addition"));
        Console.WriteLine(("- : Subtraction"));
        Console.WriteLine(("/ : Division"));
        Console.WriteLine(("* : Multiplication"));


        switch(Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine(result); 
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine(result);
            break;
            case "*":
                result = num1 * num2;
                Console.WriteLine(result);
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine(result);
                break;
            default: Console.WriteLine("Not a valid Symbol");
                break;

        }
        Console.ReadLine();
    }
}