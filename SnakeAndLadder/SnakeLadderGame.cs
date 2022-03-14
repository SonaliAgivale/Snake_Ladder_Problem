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
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
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
            Console.WriteLine("Roll:" +Roll);
            StartPos += Roll;
        }
        public void CheckOption()
        { 
            int option=random.Next(0,3);
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case LADDER:
                    player_Position += DiceRoll;
                    Console.WriteLine("LADDDER:" +player_Position);
                    break;
                case SNAKE:
                    player_Position -= DiceRoll;
                    Console.WriteLine("SNAKE:" +player_Position);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
