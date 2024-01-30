namespace Learning.Examples;

public class ForAndForeach
{
    public static void GetFor()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }

        //fizz and buzz
        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
                Console.WriteLine($"{i}");
        }
    }
}
