using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class Knight : Peace
    {
        public Knight(Board board, string idPeace, Color color) : base(board, idPeace, color)
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
