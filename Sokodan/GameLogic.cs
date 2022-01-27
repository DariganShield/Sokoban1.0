using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sokodan
{
    class GameLogic
    {
        public enum Result
        {
            Win, Loss
        }

        public Result GameRun(FrameBuffer fb)
        {
            Player hero = new Player();
            //long gameTime = Environment.TickCount64;

            while (true)
            {
                Field field = new Field();
                Wall wall = new Wall();
                fb.Clear();
                field.FieldGenerate(fb, wall);
                hero.HeroNowPoint(fb);
                ObjectGenerator objGen = new ObjectGenerator();
                objGen.GenerateObjList(fb);
                Controler control = new Controler();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPress = Console.ReadKey(intercept: true);
                    switch (keyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            hero.DoDirection(Player.Direction.Up);
                            control.ObjMove(Controler.Move.Up,hero);
                            break;
                        case ConsoleKey.DownArrow:
                            hero.DoDirection(Player.Direction.Down);
                            control.ObjMove(Controler.Move.Down, hero);
                            break;
                        case ConsoleKey.LeftArrow:
                            hero.DoDirection(Player.Direction.Left);
                            control.ObjMove(Controler.Move.Left, hero);
                            break;
                        case ConsoleKey.RightArrow:
                            hero.DoDirection(Player.Direction.Right);
                            control.ObjMove(Controler.Move.Right, hero);
                            break;
                    }
                }
                fb.Render();
                /*gameTime += 100;
                long delay = gameTime - Environment.TickCount64;
                if (delay >= 0)
                    Thread.Sleep((int) delay);
                else
                    gameTime = Environment.TickCount64;*/
            }
        }
    }
}
