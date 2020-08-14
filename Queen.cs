using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class Queen : Peace
    {
        public Queen(Board board, string idPeace, Color color) : base(board, idPeace, color)
        {
        }

        public override bool Move()
        {
            return true;
        }

        public override void ShowPossibleMove()
        {
            throw new NotImplementedException();
        }
    }
}
