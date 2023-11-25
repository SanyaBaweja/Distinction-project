using System;
using SplashKitSDK;
namespace SnakeGame
{
    public class GameTimer
    {
        private SplashKitSDK.Timer countdown;

        public GameTimer()
        {
            countdown = SplashKit.CreateTimer("Timer");
            SplashKit.StartTimer(countdown);
        }

        public double GetRemainingTime()
        {
            return SplashKit.TimerTicks(countdown) / 1000.0; // Convert milliseconds to seconds
        }

    }

}

