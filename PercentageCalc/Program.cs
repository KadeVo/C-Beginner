class DiscountCalculator
{
    static void Main()
    {
        double originalPrice;
        bool isOriginalPriceValid;

        do
        {
            Console.Write("Enter the original price of the item: ");
            isOriginalPriceValid = double.TryParse(Console.ReadLine(), out originalPrice);

            if (!isOriginalPriceValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for the original price.");
            }

        } while (!isOriginalPriceValid);

        double discountPercent;
        bool isDiscountPercentValid;

        do
        {
            Console.Write("Enter the discount percentage (e.g., 25 for 25%): ");
            isDiscountPercentValid = double.TryParse(Console.ReadLine(), out discountPercent);

            if (!isDiscountPercentValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for the discount percentage.");
            }

        } while (!isDiscountPercentValid);

     
        double discountAmount = originalPrice * discountPercent / 100;
        double finalPrice = originalPrice - discountAmount;

        Console.WriteLine($"Original price: ${originalPrice}");
        Console.WriteLine($"Discount amount: ${discountAmount}");
        Console.WriteLine($"Final price: ${finalPrice}");


        
        Console.ReadLine();
    }
}