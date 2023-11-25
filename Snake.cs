using System;
using SplashKitSDK;
namespace SnakeGame
{
	public class Snake
	{
		private Bitmap b;
		private Point2D location;


		public Snake()
		{
			b = new Bitmap("snake", "Head.png");
			location.X = 100;
			location.Y = 150;
		}

		public void Draw()
		{
			SplashKit.DrawBitmap(b, location.X, location.Y);
		}
		public Bitmap bit
		{
			get
			{
				return b;
			}
		}
		public Point2D Location
		{
			get
			{
				return location;
			}
		}
		public void Update()
		{
			if (SplashKit.KeyDown(KeyCode.UpKey) && (location.Y >= 100))
			{
				location.Y -= 2;
			}

			if (SplashKit.KeyDown(KeyCode.DownKey) && (location.Y + b.Height <= 700))
			{
				location.Y += 2;
			}

			if (SplashKit.KeyDown(KeyCode.RightKey) && (location.X + b.Width <= 700))
			{
				location.X += 2;
			}

			if (SplashKit.KeyDown(KeyCode.LeftKey) && (location.X >= 100))
			{
				location.X -= 2;
			}

		}
        public void Remove()
        {
            SplashKit.FreeBitmap(b);
        }
        public void GameEndSnake()
		{
			b = new Bitmap("snakedead", "DeadHead.png");
		}
	}
}



