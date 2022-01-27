using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokodan
{
    class Point
    {
        public int X;
        public int Y;
        public char Character;

        public Point(int x, int y, char c)
        {
            X = x;
            Y = y;
            Character = c;
        }
    }
}
