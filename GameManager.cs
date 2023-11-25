using System;
using SplashKitSDK;

namespace SnakeGame
{
    public class GameManager
    {
        private Window _window;
        private Snake _snake;
        private Food _food;
        private Score _score;
        private GameTimer _gameTimer;
        private TimeIncrementFood _timeIncrementFood;
        private TimeDecrementFood _poisonfood;
        int gameTimeInSeconds = 40;
        int remainingTime;
        SoundEffect gamemusic;
        bool gameEnded;

        public GameManager(Window window)
        {
            _window = window;
            _snake = new Snake();
            _food = new Food();
            _score = new Score();
            _gameTimer = new GameTimer();
            _timeIncrementFood = new TimeIncrementFood();
            _poisonfood = new TimeDecrementFood();
            remainingTime = gameTimeInSeconds;
            gamemusic = new SoundEffect("Naagin", "Naagin.mp3");
            gameEnded = false;
        }

        public void DrawItems()
        {
            ScreenItems();
            Objects();
        }
        public void ScreenItems()
        {
            _window.FillRectangle(Color.LightGreen, 100, 100, 600, 600);
            gamemusic.Play();

            remainingTime = (int)(gameTimeInSeconds - _gameTimer.GetRemainingTime());

            _window.DrawText("Score: " + _score.GetScore(), Color.Black, "DroidSansMono.ttf", 50, 160, 45);
            if (remainingTime > 10)
            {
                _window.DrawText("Timer: " + remainingTime, Color.Black, "DroidSansMono.ttf", 50, 500, 45);
            }
            else if(remainingTime <= 10)
            {
                if (remainingTime < 0)
                {
                    remainingTime = 0;
                }
                _window.DrawText("Timer: " + remainingTime, Color.Red, "DroidSansMono.ttf", 50, 500, 45);
            }

        }
        public void Objects()
        {
            _food.Draw();
            _snake.Draw();
        }

        public void UpdateItems()
        {
            
            if (remainingTime > 0)
            {
                _snake.Update();
            }

            if (_food.Collision(_snake))
            {
                _score.IncrementScore(10);
                _food = new Food();

            }
            if (remainingTime < 20 && remainingTime > 15)
            {
                _timeIncrementFood.Draw();

            }
            
            if (_timeIncrementFood.Collision(_snake))
            {
                gameTimeInSeconds += 5;
                _timeIncrementFood.Remove();
            }

            if (remainingTime < 19 && remainingTime > 16)
            {
                _poisonfood.Draw();
                
            }
            
            if (_poisonfood.Collision(_snake))
            {
                gameTimeInSeconds -= 5;
                _poisonfood.Remove();
            }


            if (remainingTime == 0)
            {
                
                _window.DrawText("Game Ended", Color.Black, "DroidSansMono.ttf", 80, 160, 350);
                _window.DrawText("Score: " + _score.GetScore(), Color.Black, "DroidSansMono.ttf", 50, 280, 450);
                _window.DrawText("Press Enter to Restart", Color.Black, "DroidSansMono.ttf", 25, 240, 550);
                gamemusic.Stop();

                _snake.GameEndSnake();

            }
            
        }
        public bool GameEnded()
        {
            if (remainingTime == 0)
            {
                return gameEnded = true;
            }
            else return false;
        }
        
        

    }
}
