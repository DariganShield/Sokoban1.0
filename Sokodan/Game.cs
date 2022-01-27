using System;

namespace Sokodan
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите Длину и Ширину");
            Console.SetWindowSize(FrameBuffer.Wight, FrameBuffer.Height);
            Console.Title = "Sokodan";
            Console.CursorVisible = false;
            FrameBuffer fb = new FrameBuffer();
            while (true)
            {
                GameLogic gl = new GameLogic();
                gl.GameRun(fb);
                fb.Render();
                Console.ReadKey(intercept: true);
            }
        }
    }
}
