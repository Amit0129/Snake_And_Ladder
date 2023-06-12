using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        public static int No_play(int position)
        {
            Console.WriteLine($"The Player position is : {position}");
            return position;
        }
        public static int Ladder(int position, int roll, int winPosition)
        {
            position += roll;
            if (position > winPosition)
            {
                position -= roll;
            }
            Console.WriteLine("Playear position now is {0}", position);
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
            int winPosition = 100;
            Console.WriteLine("Playear position now is {0}", position);
            Random random = new Random();

            while (position < 100)
            {


                int rollDice = random.Next(1, 7);
                Console.WriteLine($"The value of dice after roll is : {rollDice}");

                int checkOption = random.Next(1, 4);
                Console.WriteLine("Check Option is {0}", checkOption);

                switch (checkOption)
                {
                    case 1:
                        position = No_play(position);

                        break;
                    case 2:
                        position = Ladder(position, rollDice, winPosition);
                        break;
                    case 3:
                        position = Snake(position, rollDice);
                        break;
                }
            }
        }
    }
}