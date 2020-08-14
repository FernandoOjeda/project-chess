using System;
using System.Collections.Generic;
using System.Text;

namespace Project_chess.Chess
{
    public abstract class Movements
    {
        protected Peace peace;
        protected Box origin;
        protected Board board;
        protected Stack<Play> stack;

        // posible moves between a box and other box
        public static readonly byte ENEMY = 2;
        public static readonly byte FREE = 2;
        public static readonly byte ALLY = 2;
        public static readonly byte INVALID = 2;
        public static readonly byte CHECK = 2; // there was check

        public Movements(Peace peace, Box origin)
        {
            this.peace = peace;
            this.origin = origin;
            this.board = peace.Board;
            stack = new Stack<Play>();
        }

        /**
         * Check what type of movement is
         */
         public byte CheckMoviment(Peace peace, Box origin, Box destination)
        {
            if (peace == null)
                return INVALID; // nothing to move
            else if (destination.Peace == null)
                return FREE; // box free
            else if (peace.Color != destination.Peace.Color) // something to eat
                return ENEMY;
            else
                return ALLY;

        }
    }
}
