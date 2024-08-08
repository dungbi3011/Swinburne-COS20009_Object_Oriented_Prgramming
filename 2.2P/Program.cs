using SplashKitSDK;
namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Shape myDraw = new();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myDraw.Draw();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myDraw.X = SplashKit.MouseX();
                    myDraw.Y = SplashKit.MouseY();
                    myDraw.Color = SplashKit.ColorGreen();
                }

                if (myDraw.IsAt(SplashKit.MousePosition()))
                {
                    if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                    {
                        myDraw.Color = Color.RandomRGB(255);
                    }
                }
                SplashKit.RefreshScreen();

            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}
