using System;

class DiscountCalculator
{
    static void Main()
    {
        
        Console.Write("Enter the original price of the item: ");
        double originalPrice = double.Parse(Console.ReadLine());

     
        Console.Write("Enter the discount percentage (e.g., 25 for 25%): ");
        double discountPercent = double.Parse(Console.ReadLine()) / 100; 
        
        double discountAmount = originalPrice * discountPercent;

      
        double finalPrice = originalPrice - discountAmount;

     
        Console.WriteLine("Original price: ${0:0.00}", originalPrice);
        Console.WriteLine("Discount amount: ${0:0.00}", discountAmount);
        Console.WriteLine("Final price: ${0:0.00}", finalPrice);

        Console.ReadLine(); 
    }
}