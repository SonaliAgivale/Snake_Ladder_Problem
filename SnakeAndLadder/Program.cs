﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome To Snake Ladder Game ****");
            //creating object of class
            SnakeLadderGame snakeLadder = new SnakeLadderGame();
            SnakeLadderGame.StartGame();//static method
            snakeLadder.PlayerRoll();
            Console.WriteLine("----------------------");
            snakeLadder.CheckOption();  
            Console.ReadLine();
        }
    }
}
