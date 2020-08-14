using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class Pawn : Peace, IPromotion
    {
        public Pawn(Board board, string idPeace, Color color) : base(board, idPeace, color)
        {
        }

        public override bool Move()
        {
            throw new NotImplementedException();
        }

        public Peace Promotion(Peace peace)
        {
            throw new NotImplementedException();
        }

        public override void ShowPossibleMove()
        {
            throw new NotImplementedException();
        }
    }
}
