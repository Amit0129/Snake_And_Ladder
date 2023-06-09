namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder game!");
            int position = 0;
            Console.WriteLine("Player now in {0}th position",position);

            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"The value of dice after roll is : {diceRoll}");
        }
    }
}