namespace Learning.Examples;

public class Larger
{
    public static int WhichLarger()
    {
        int num1;
        int num2;
        int largerValue;

        Console.WriteLine("Digite um número: ");
        var response1 = Console.ReadLine();
        num1 = Int32.Parse(response1);

        Console.WriteLine("Digite outro número: ");
        var response2 = Console.ReadLine();
        num2 = Int32.Parse(response2);

        largerValue = Math.Max(num1, num2);
        if (num1 == num2)
        {
            Console.WriteLine("São iguais!");
        }
        else
        {
            Console.WriteLine("Maior número: " + largerValue);
        }

        return largerValue;
    }
    public static int WhichLarger(int num1, int num2)
    {
        int largerValue;

        largerValue = Math.Max(num1, num2);
        Console.WriteLine("Maior número: " + largerValue);

        return largerValue;
    }
}
