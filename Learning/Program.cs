using Learning.Examples;
using System.Linq.Expressions;

namespace Learning;

class Program
{
    static void Main()
    {

        //Block("Imprimir na tela");
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine();

        //Block("Gerar número aleatório");
        //Console.WriteLine(Numbers.GenerateRandoms());
        //Console.WriteLine();

        //Block("Verificar maior número");
        //Larger.WhichLarger();
        //Console.WriteLine();

        //Block("Jogar dados");
        //Dice.PlayDice();
        //Console.WriteLine();

        //Block("------------------");
        //Console.WriteLine();

        //Random dice = new Random();

        //int roll1 = dice.Next(1, 7);
        //int roll2 = dice.Next(1, 7);
        //int roll3 = dice.Next(1, 7);

        //int total = roll1 + roll2 + roll3;

        //Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        //Block("Laço Foreach");
        //Repetition.LoadLoop();
        //Console.WriteLine();

        //Block("Verificar Inicial");
        //Repetition.VerifyStarts();
        //Console.WriteLine();

        Block("Notas de alunos");
        Graded.GradedAssigns();
        Console.WriteLine();
    }


    public static void Block(string name)
    {
        Console.WriteLine("------------------");
        Console.WriteLine($"{name}");
        Console.WriteLine("------------------");
        Console.WriteLine();
    }
}
