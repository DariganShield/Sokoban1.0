using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokodan
{
    class Box : Barrier
    {
        public int CountOfObj = 7;
        public char pixelSymbol = 'o';
        public static List<Point> ObjectList = new List<Point>();
    }

}

