using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokodan
{
    class Controler:Box
    {
        public enum Move
        {
            Up, Right, Down, Left
        }
        public void ObjMove(Move move, Player player)
        {
            foreach (var element in ObjectList)
            {
                if (element.X == player.HeroPoint.X && element.Y == player.HeroPoint.Y)
                {
                    switch (move)
                    {
                        case Move.Up:
                            if (element.Y > 1)
                            {
                                element.Y--;
                            }
                            else  player.HeroPoint.Y++;
                            break;
                        case Move.Down:
                            if (element.Y < Field.Height - 2)
                            {
                                element.Y++;
                            }
                            else player.HeroPoint.Y--;
                            break;
                        case Move.Left:
                            if (element.X > 1)
                            {
                                element.X--;
                            }
                            else player.HeroPoint.X++;
                            break;
                        case Move.Right:
                            if (element.X < Field.Width - 2)
                            {
                                element.X++;
                            }
                            else player.HeroPoint.X--;
                            break;
                    }
                }
  
            }

            for (int i = 0; i < ObjectList.Count; i++)
            {
                for (int j = 1; j < ObjectList.Count; j++)
                {
                    if (ObjectList[i].X == ObjectList[j].X && ObjectList[i].Y == ObjectList[j].Y)
                    {
                        switch (move)
                        {
                            case Move.Up:
                                ObjectList[i].Y++;
                                player.HeroPoint.Y++;
                                break;
                            case Move.Down:
                                ObjectList[i].Y--;
                                player.HeroPoint.Y--;
                                break;
                            case Move.Left:
                                ObjectList[i].X++;
                                player.HeroPoint.X--;
                                break;
                            case Move.Right:
                                ObjectList[i].X--;
                                player.HeroPoint.X++;
                                break;
                        }
                    }
                        
                }
                
            }
        }
    }
}
