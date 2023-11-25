using System;
using SplashKitSDK;

namespace SnakeGame
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("SnakeGame", 800, 800);
            GameManager gameManager = new GameManager(window);
           
            do
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen();

                if (gameManager.GameEnded())
                {
                    if (SplashKit.KeyDown(KeyCode.ReturnKey))
                    {
                        gameManager = new GameManager(window);
                    }
                }
                gameManager.DrawItems();
                gameManager.UpdateItems();

                SplashKit.RefreshScreen();

            }
            while (!window.CloseRequested);

            
        }
    }
}





