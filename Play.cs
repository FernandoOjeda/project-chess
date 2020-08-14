using System;
using System.Collections.Generic;
using System.Text;

namespace Project_chess.Chess
{
    public class Play
    {
        // types plays
        public static readonly short MOVE = 0x001;
        public static readonly short EAT = 0x002;
        public static readonly short SHORT_CASTING = 0x004;
        public static readonly short LONG_CATING = 0x008;
        public static readonly short PROMOTION = 0x010;
        public static readonly short BOUBLE_STEP = 0x020;
        public static readonly short EAT_STEP = 0x040;
        public static readonly short CHECK = 0x080;
        public static readonly short MATE = 0x1;
        public short indicator = MOVE;

        private Box origin;
        private Box destination;
        private Peace move;
        private Peace eat;
        private Rook rook;

        public Play(Box origin, Box destination)
        {
            this.origin = origin;
            this.destination = destination;
            this.move = origin.Peace;
            this.eat = destination.Peace;
        }

        public Play(Box origin, Box destination, Rook rook) : this(origin, destination)
        {
            this.rook = rook;
        }

        public Play(Box origin, Box destination, Peace move, Peace eat, short indicator) : this(origin, destination) 
        {
            this.move = move;
            this.eat = eat;
            Active(indicator);
        }

        /**
         * Check the type of the play
         */ 
        public void CheckTypePlay()
        {
            if (eat != null)
                Active(EAT);

        }

        // Active changing the indicator to 1
        public void Active(short indicator)
        {
            this.indicator |= indicator;
        }

    }
}
