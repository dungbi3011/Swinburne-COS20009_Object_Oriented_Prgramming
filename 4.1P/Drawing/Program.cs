using System;
using SplashKitSDK;
using System.Threading;

namespace Drawing
{
    public class Program
    {
        public static void Main()
        {
            new Window("new", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                //square
                if (SplashKit.KeyDown(KeyCode.RKey))
                {
                    SplashKit.FillRectangle(Color.Green, SplashKit.MousePosition().X, SplashKit.MousePosition().Y, 200, 200);
                    SplashKit.DrawRectangle(Color.Black, SplashKit.MousePosition().X, SplashKit.MousePosition().Y, 200, 200);
                }
                //circle
                if (SplashKit.KeyDown(KeyCode.CKey))
                {
                    SplashKit.FillCircle(Color.Blue, SplashKit.MousePosition().X, SplashKit.MousePosition().Y, 50);
                    SplashKit.DrawCircle(Color.Black, SplashKit.MousePosition().X, SplashKit.MousePosition().Y, 50);
                }
                //rectangle
                if (SplashKit.KeyDown(KeyCode.LKey))
                {
                    SplashKit.DrawLine(Color.Black, SplashKit.MousePosition().X, SplashKit.MousePosition().Y, SplashKit.MousePosition().X + 200, SplashKit.MousePosition().Y);

                }
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("new"));
        }
    }
}