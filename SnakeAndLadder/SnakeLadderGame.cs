using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadderGame
    {
        public static int StartPos;
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        public int player_Position = 0, DiceRoll;
        Random random = new Random();
        public SnakeLadderGame()
        {
            StartPos = 0;
        }
        public static void StartGame()
        {
            Console.WriteLine("******* Game Start *******");
            Console.WriteLine("Starting Position:" + StartPos);
        }
        //UC2 
        public void PlayerRoll()
        {
            int Roll = random.Next(1, 7);
            Console.WriteLine("Roll:" + Roll);
            StartPos += Roll;
        }
        //while(player_Position<WINNING_POSITION)
        //{
        //       DiceRoll = random.Next(1, 7);
        //       Console.WriteLine("Player gets Dice Number: " + DiceRoll);
        public void CheckOption()
        {
            while (player_Position < WINNING_POSITION)
            {
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("Player gets Dice Number: " + DiceRoll);

                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;
                    case LADDER:
                        player_Position += DiceRoll;
                        Console.WriteLine("LADDDER:" + player_Position);
                        break;
                    case SNAKE:
                        player_Position -= DiceRoll;
                        Console.WriteLine("SNAKE:" + player_Position);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                 }
            }
        }

        private void CheckBoundary()
        {
            if (player_Position < 0)
                player_Position = 0;
            else if (player_Position >= 100)
                player_Position = 100;
        }

        // This will roll die untill player wins
        public void PlayTillEnd()
        {
            while (player_Position < 100)
                PlayerRoll();
            Console.WriteLine("\nCongratulations!! You Won!!");
        }
    }  
}
