using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sokodan
{
    class Player
    {
        public enum  Direction
        {
            Up, Right, Down, Left
        }

        public void DoDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (HeroPoint.Y > 1) HeroPoint.Y--;
                    break;
                case Direction.Down:
                    if (HeroPoint.Y < Field.Height - 2) HeroPoint.Y++;
                    break;
                case Direction.Left:
                    if (HeroPoint.X > 1) HeroPoint.X--;
                    break;
                case Direction.Right:
                    if (HeroPoint.X < Field.Width - 2) HeroPoint.X++;
                    break;
            }
        }
        public Point HeroPoint = new Point(Field.Width / 2 - 1, Field.Height / 2, 'P');
        public void HeroNowPoint(FrameBuffer fb)
        {
            fb.SetPixel(HeroPoint.X,HeroPoint.Y,HeroPoint.Character);
        }
        /*public void HeroDirection(Move move)
        {
            switch(move)
            {
                case Move.Up:
                    if (HeroPoint.Y < 2)
                    {
                        DoDirection(Move.Down);
                    }
                    DoDirection(Move.Up);
                    break;
                case Move.Down:
                    if (HeroPoint.Y > Field.Height - 3)
                    {
                        DoDirection(Move.Up);
                    }
                    DoDirection(Move.Down);
                    break;
                case Move.Left:
                    if (HeroPoint.X < 2)
                    {
                        DoDirection(Move.Right);
                    }
                    DoDirection(Move.Left);
                    break;
                case Move.Right:
                    if (HeroPoint.X > Field.Width - 3)
                    {
                        DoDirection(Move.Left);
                    }
                    DoDirection(Move.Right);
                    break;
            }
        }*/
    }
}
