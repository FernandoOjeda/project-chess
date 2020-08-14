using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public class Board
    {
        private Box[,] boxes;
        private Peace[] peacesBlack;
        private Peace[] peacesWhite;
        // These will be enum
        private static readonly byte NUM_ROWS = 8;
        private static readonly byte NUM_COLUMNS = 8;
        private static readonly byte RQ = 0; // Rook Queen
        private static readonly byte KQ = 1; // Knight Queen 
        private static readonly byte BQ = 2; // Bishop Queen
        private static readonly byte Q = 3;  // Queen 
        private static readonly byte K = 4;  // King
        private static readonly byte BK = 5; // Bishop King 
        private static readonly byte KK = 6; // Knight King
        private static readonly byte RK = 7; // Rook King
        public static readonly Color WHITE = Color.White;
        public static readonly Color BLACK = Color.Black;

        private static string[] idPeaces = 
        {
            "RQ",  "KQ",  "BQ",   "Q",  "K", "BK",  "KK",  "RK",
            "PRQ", "PKQ", "PBQ", "PQ", "PK", "PBK", "PKK", "PRK"
        };

        public Board()
        {
            boxes = CreateBoxes();
            peacesWhite = CreatePeaces(WHITE);
            peacesBlack = CreatePeaces(BLACK);
            PlacePeaces();
        }

        public Box[,] CreateBoxes()
        {
            Box[,] boxes = new Box[NUM_ROWS,NUM_COLUMNS];
            for (int row = 0; row < NUM_ROWS; row++)
            {
                for (int colum = 0; colum<NUM_COLUMNS; colum++)
                {
                    bool isWhite = ((row + colum) % 2 == 0);
                    Box box = new Box(this, isWhite? WHITE:BLACK, row, colum);
                    boxes[row,colum] = box; 
                }
            }
            return boxes;
        }

        public Peace[] CreatePeaces(Color color)
        {
            Peace[] peaces = new Peace[8 * 2];
            peaces[RQ] = new Rook(this, idPeaces[RQ], color);
            peaces[KQ] = new Knight(this, idPeaces[KQ], color);
            peaces[BQ] = new Bishop(this, idPeaces[BQ], color);
            peaces[Q]  = new Queen(this, idPeaces[Q], color);
            peaces[K]  = new King(this, idPeaces[K], color);
            peaces[BK] = new Bishop(this, idPeaces[BK], color);
            peaces[KK] = new Knight(this, idPeaces[KK], color);
            peaces[RK] = new Rook(this, idPeaces[RK], color);

            for (int i = 0; i<NUM_COLUMNS; i++)
            {
                peaces[8 + i] = new Pawn(this, idPeaces[8+i], color);
            }
            return peaces;
        }

        public void PlacePeaces()
        {
            // Put the black peaces.
            boxes[0, 0].PlacePeace(peacesBlack[RQ]);
            boxes[0, 1].PlacePeace(peacesBlack[KQ]);
            boxes[0, 2].PlacePeace(peacesBlack[BQ]);
            boxes[0, 3].PlacePeace(peacesBlack[Q]);
            boxes[0, 4].PlacePeace(peacesBlack[K]);
            boxes[0, 5].PlacePeace(peacesBlack[BK]);
            boxes[0, 6].PlacePeace(peacesBlack[KK]);
            boxes[0, 7].PlacePeace(peacesBlack[RK]);

            for (int i = 0; i<NUM_COLUMNS; i++)
            {
                boxes[1, i].PlacePeace(peacesBlack[8 + i]);
            }

            // Put the white peaces.
            boxes[7, 0].PlacePeace(peacesWhite[RQ]);
            boxes[7, 1].PlacePeace(peacesWhite[KQ]);
            boxes[7, 2].PlacePeace(peacesWhite[BQ]);
            boxes[7, 3].PlacePeace(peacesWhite[Q]);
            boxes[7, 4].PlacePeace(peacesWhite[K]);
            boxes[7, 5].PlacePeace(peacesWhite[BK]);
            boxes[7, 6].PlacePeace(peacesWhite[KK]);
            boxes[7, 7].PlacePeace(peacesWhite[RK]);

            for (int i = 0; i < NUM_COLUMNS; i++)
            {
                boxes[6, i].PlacePeace(peacesWhite[8 + i]);
            }
        }

        public Box[,] GetBoxes()
        {
            return this.boxes;
        }
    }
}
