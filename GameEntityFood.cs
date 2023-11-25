using System;
using SplashKitSDK;

namespace SnakeGame
{
    public abstract class GameEntityFood:IDrawable
    {
        protected Bitmap _bitmap;
        protected Point2D _position;

        public virtual void Draw()
        {
            _bitmap.Draw(_position.X, _position.Y);
        }

        public virtual void Remove()
        {
            SplashKit.FreeBitmap(_bitmap);
        }

        public abstract bool Collision(Snake s);
    }
}

