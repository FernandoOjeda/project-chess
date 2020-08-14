using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class Box
    {
        private Board board;
        private Color color;
        private int coordinateX;
        private int coordinateY;
        private Peace peace;
        private static char[] CHARACTERES = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        public Peace Peace { get => peace; set => peace = value; }

        public Box(Board board, Color color, int coordinateX, int coordinateY)
        {
            this.board = board;
            this.color = color;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.peace = null;
        }

        public void PlacePeace(Peace peace)
        {
            this.peace = peace;
        }

        public void RemovePeace()
        {
            this.peace = null;
        }

        public bool MovePeace(Box destiantion)
        {
            if (peace == null) // nothing to move
            {
                return false;
            }
            else if (destiantion == null)
                peace = null;
            else
            {
                if (destiantion.peace != null) //eat peace
                    destiantion.peace = null;

                // Move the peace
                destiantion.peace = peace;
                peace = null;   
            }
            return true;
        }

        public override string ToString()
        {
            return CHARACTERES[coordinateY].ToString() + (8 - coordinateX).ToString();
        }
    }
}
