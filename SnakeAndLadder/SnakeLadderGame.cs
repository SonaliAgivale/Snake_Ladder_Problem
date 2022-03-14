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
    }
}
