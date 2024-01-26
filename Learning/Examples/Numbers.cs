namespace Learning.Examples;

public class Numbers
{
    public static int GenerateRandoms()
    {
        Random rand = new();
        int roll = rand.Next(1, 7);

        return roll;
    }
}
