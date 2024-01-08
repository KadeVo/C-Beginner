using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;

        do
        {
            Console.WriteLine("Enter your first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an symbol: ");
            Console.WriteLine(("+ : Addition"));
            Console.WriteLine(("- : Subtraction"));
            Console.WriteLine(("/ : Division"));
            Console.WriteLine(("* : Multiplication"));


            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Not a valid Symbol");
                    break;

            }
            Console.WriteLine("Enter 'done' to finish or enter anything else to continue:");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "done")
            {
                Console.WriteLine("Program closing...");
                break;
            }
        } while (true);

        Console.ReadLine();


    }
    }
