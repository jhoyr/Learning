namespace Learning.Examples;

public class Dice
{
    public static void PlayDice()
    {
        int player1 = Numbers.GenerateRandoms();
        Console.WriteLine("Player 1: " + player1);

        int player2 = Numbers.GenerateRandoms();
        Console.WriteLine("Player 2: " + player2);

        var winner = Larger.WhichLarger(player1, player2);

        if (player1 == player2)
        {
            Console.WriteLine("Empate");
        }
        else if (winner == player1)
        {
            Console.WriteLine("Player 1 Wins!");
        } else if (winner == player2)
        {
            Console.WriteLine("Player 2 Wins!");
        }
        else
        {
            Console.WriteLine("Erro");
        }
    }
}
