class RandomItemPicker
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Random Item Picker!");

        List<string> items = GetItemsFromUser();

        if (items.Count == 0)
        {
            Console.WriteLine("No items entered. Exiting...");
            return;
        }

        Random random = new Random();
        string selectedItem = PickRandomItem(items, random);

        Console.WriteLine($"\nThe randomly selected item is: {selectedItem}");

        Console.ReadLine();
    }

    static List<string> GetItemsFromUser()
    {
        List<string> items = new List<string>();

        while (true)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "done")
            {
                break;
            }

            if (!string.IsNullOrEmpty(input))
            {
                items.Add(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid item.");
            }
        }

        return items;
    }

    static string PickRandomItem(List<string> items, Random random)
    {
        int index = random.Next(items.Count);
        return items[index];
    }
}