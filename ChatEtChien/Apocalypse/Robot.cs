using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Robot
    {
        public string CodeRobot { get; set; }
        public Piece[] Pieces { get; set; }

        public Robot (string codeRobot, Piece piece1, Piece piece2, Piece piece3)
        {
            CodeRobot = codeRobot;
            Pieces[0] = piece1;
            Pieces[1] = piece2;
            Pieces[2] = piece3;
        }   
    }
}
