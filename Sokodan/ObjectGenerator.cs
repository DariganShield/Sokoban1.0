using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sokodan
{
    class ObjectGenerator : Box

    {
        public enum Type
        {
            Movable,
            Push,
            Through
        }
        public void GenerateObjList(FrameBuffer fb)
        {
            Random rnd = new Random();

            var x = 0;
            var y = 0;
            
            if (ObjectList.Count == 0)
            {
                for (int i = 0; i < CountOfObj; i++)
                {
                    var point = RandomPoint(rnd);
                    ObjectList.Add(point);
                    fb.SetPixel(point.X,point.Y,point.Character);
                    i++;
                }
            }
            else
            {
                foreach (var element in ObjectList)
                {
                    fb.SetPixel(element.X, element.Y, element.Character);
                }
            }
            
        }

        private static Point RandomPoint(Random rnd)
        {
            int x;
            int y;
            x = rnd.Next(2, Field.Width - 2);
            y = rnd.Next(2, Field.Height - 2);
            var point = new Point(x, y, 'o');
            foreach (var element in ObjectList)
            {
                if (element.X == point.X && element.Y == point.Y)
                {
                    RandomPoint(rnd);
                }
            }
            return point;
        }
    }
}
