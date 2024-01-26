namespace Learning.Examples;

public class Repetition
{
    private const string Value = "B";

    public static void LoadLoop()
    {
        int[] inventory = [200, 450, 700, 175, 250];
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");
    }

    public static void VerifyStarts()
    {
        string[] orderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

        foreach (string orderID in orderIDs)
        {
            if (orderID.StartsWith(Value))
            {
                Console.WriteLine(orderID);
            }
        }
    }
}
