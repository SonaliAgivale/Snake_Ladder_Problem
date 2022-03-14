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
            Random random = new Random();
            int Roll = random.Next(1, 7);
            Console.WriteLine("Roll:" +Roll);
            StartPos += Roll;
        }
    }
}
