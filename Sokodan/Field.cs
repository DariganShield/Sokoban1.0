using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokodan
{
    class Field
    {
        public static int Width = Convert.ToInt32(Console.ReadLine());
        public static int Height = Convert.ToInt32(Console.ReadLine());
        public void FieldGenerate(FrameBuffer fb, Wall wall)
        {
            int x = 0;
            int y = 0;
            while (x*y < fb.Chars.Length)
            {
                if (x < Width)
                {
                    fb.SetPixel(x,y,wall.PixelSymbol);
                    fb.SetPixel(x, Height-1, wall.PixelSymbol);
                    x++;
                }
                else
                {
                    fb.SetPixel(0, y, wall.PixelSymbol);
                    fb.SetPixel(Width-1, y, wall.PixelSymbol);
                    y++;
                }
            }
        }
        /*public bool Update()
        {

        }*/
    }
}
