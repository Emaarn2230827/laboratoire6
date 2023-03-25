using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Piece
    {
        protected string TypePiece{get; set;}
        protected int ValeurPiece{get; set;}   

        protected Piece( string typepiece, int val)
        {
            TypePiece = typepiece;
            ValeurPiece = val;
        }

    }
}
