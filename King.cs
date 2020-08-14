using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class King : Peace, ICastling
    {
        public King(Board board, string idPeace, Color color) : base(board, idPeace, color)
        {
        }

        public void Castling(Box origin, Box destination)
        {
            Peace peace = destination.Peace;
            destination.Peace = origin.Peace;
            origin.Peace = peace;
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
