using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project_chess.Chess
{
    public abstract class Peace
    {
        //private bool white;
        /**
         * Identificador unico de la pieza en un bando
         *   TD,   CD,   AD,   D,   R,   AR,   CR,   TR
         *  PTD,  PCD,  PAD,  PD,  PR,  PAR,  PCR,  PTR
         */
        private string idPeace;
        /**
         * Tipo de pieza (Primera letra del nombre de la clase)
         *   T, C, A, D, R, P
         */
        private string type;
        private Color color;
        private Board board;
        private int numMov;
        private string idImage;

        public Peace(Board board, string idPeace, Color color)
        {
            this.Board = board;
            this.IdPeace = idPeace;
            this.Color = color;
            this.type = GetType().Name.Substring(0,1);
            //this.idImage = GetType().Name + " " + stringColor();

        }

        public string IdPeace { get => idPeace; set => idPeace = value; }
        public string Type { get => type; set => type = value; }
        public Color Color { get => color; set => color = value; }
        public Board Board { get => board; set => board = value; }

        public void Reset() //reinicializar 
        {
            numMov = 0;
        }

        public bool isWhite()
        {
            return Color == Board.WHITE;
        }

        public bool isBlack()
        {
            return Color == Board.BLACK;
        }

        public Color ColorEnemy()
        {
            return isWhite() ? Board.BLACK : Board.WHITE;
        }

        public string StringEnemy()
        {
            return isWhite() ? "white" : "black";
        }

        public override string ToString()
        {
            return idPeace.ToString();
        }
        public abstract bool Move();
        public abstract void ShowPossibleMove();
    }
}
