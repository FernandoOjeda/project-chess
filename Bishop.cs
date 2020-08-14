using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class Bishop : Peace
    {
        public Bishop(Board board, string idPeace, Color color) : base(board, idPeace, color)
        {
        }

        public override bool Move()
        {
            throw new NotImplementedException();
        }

        public override void ShowPossibleMove()
        {
            throw new NotImplementedException();
        }
    }
}
