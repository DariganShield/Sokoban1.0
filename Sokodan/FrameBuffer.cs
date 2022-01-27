using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sokodan
{
    class FrameBuffer
    {
        public static int Wight = Field.Width;
        public static int Height = Field.Height;
        public static int Area = Wight * Height;

        public char[] Chars = new char[Area];

        public void SetPixel(int x, int y, char character)
        {
            Chars[y * Wight + x] = character;
            Point point = new Point(x, y, character);
        }

        public void Clear()
        {
            for (int i = 0; i < Area; i++)
            {
                Chars[i] = ' ';
            }
        }

        public void Render()
        {
            Console.SetCursorPosition(0,0);
            for (int i = 1; i <= Area; i++)
            {
                char pxl = Chars[i - 1];
                Console.Write(pxl);
                if (i % Wight == 0)
                {
                    Console.SetCursorPosition(0, i / Wight);
                }
            }
        }
    }
}
