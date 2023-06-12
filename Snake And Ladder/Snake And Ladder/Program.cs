namespace Snake_And_Ladder
{
    internal class Program
    {
        public static int No_play(int position)
        {
            Console.WriteLine($"The Player position is : {position}");
            return position;
        }
        public static int Ladder(int position, int diceRoll)
        {
            position += diceRoll;
            return position;
        }
        public static int Snake(int position, int diceRoll)
        {
            position -= diceRoll;
            if (position < 0)
            {
                position = 0;
            }
            return position;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Snake And Ladder game!");
            int position = 0;
            Console.WriteLine("Player now in {0}th position", position);
         
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"The value of dice after roll is : {diceRoll}");
            int optionCheck = random.Next(1, 4);
            
            switch (optionCheck)
            {
                case 1:
                    position = No_play(position);
                    //Console.WriteLine($"The Player position is : {position}");
                    Console.WriteLine("NNNNNNNNNN");
                    Console.WriteLine("Playear position now is {0}", position);
                    break;
                case 2:
                    position = Ladder(position, diceRoll);
                    //position += diceRoll;
                    Console.WriteLine("LLLLLLLLLLLL");
                    Console.WriteLine("Playear position now is {0}", position);
                    break;
                default:
                    position = Snake(position, diceRoll);
                    //position -= diceRoll;
                    //if (position < 0)
                    //{
                    //    position = 0;
                    //}
                    Console.WriteLine("SSSSSSSSSSSS");
                    Console.WriteLine("Playear position now is {0}", position);
                    break;
            }
        }
    }
}