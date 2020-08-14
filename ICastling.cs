using System;
using System.Collections.Generic;
using System.Text;

namespace Project_chess.Chess
{
    public interface ICastling
    {
        void Castling(Box origin, Box destination);
    }
}
