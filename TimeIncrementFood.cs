using System;
using SplashKitSDK;
namespace SnakeGame
{
    public class TimeIncrementFood:GameEntityFood
    {
       
        public TimeIncrementFood():base()
        {
            _position.X = SplashKit.Rnd(100, 600);
            _position.Y = SplashKit.Rnd(100, 600);

            _bitmap = new Bitmap("Bonusfood", "Bonusfood.png");
        }

        public override void Draw()
        {
            base.Draw();
        }

        public override void Remove()
        {
            base.Remove();
        }

        public override bool Collision(Snake s)
        {
            return SplashKit.BitmapCollision(_bitmap, _position.X, _position.Y, s.bit, s.Location.X, s.Location.Y);
        }

    }
}

