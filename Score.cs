using System;
using SplashKitSDK;

namespace SnakeGame
{
    public class Score
    {
        private int score;

        public Score()
        {
            score = 0;
        }

        public int GetScore()
        {
            return score;
        }

        public void IncrementScore(int incrementScore)
        {
            score += incrementScore;
        }

        public void GameEndScore()
        {
            score = 0;
        }
    }
}
