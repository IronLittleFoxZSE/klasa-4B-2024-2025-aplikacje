﻿using System;

namespace MoveOnBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Draw();

            Player player = new Player();
            while(true)
                player.Move();

        }
    }
}