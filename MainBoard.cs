using System;
using System.Collections.Generic;
using System.Text;

namespace Project_chess.Chess
{
    public class MainBoard
    {
        public static void Main(string []arg)
        {
            Board board = new Board();
            Box[,] boxes = board.GetBoxes();
            for(int i = 0; i < boxes.GetLength(0); i++)
            {
                for (int j = 0; j < boxes.GetLength(1); j++)
                {
                    Console.Write(boxes[i, j].Peace.IdPeace + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
