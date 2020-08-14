using System;
using System.Collections.Generic;
using System.Text;

namespace Project_chess.Chess
{
    public interface IPromotion
    {
        Peace Promotion(Peace peace);
    }
}
