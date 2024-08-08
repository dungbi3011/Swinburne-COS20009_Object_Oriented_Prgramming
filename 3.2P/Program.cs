using ShapeDrawer;
using SplashKitSDK;

namespace DrawingProgram
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);

            Drawing drawMe = new Drawing();

            do
            {
                SplashKit.ProcessEvents();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    drawMe.AddShape(new Shape((int)SplashKit.MousePosition().X, (int)SplashKit.MousePosition().Y));
                }

                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    drawMe.Background = Color.RandomRGB(255);
                }

                if (SplashKit.KeyDown(KeyCode.DeleteKey) || SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    drawMe.DeleteSelectedShapes();
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawMe.SelectShapeAt(SplashKit.MousePosition());
                }

                SplashKit.ClearScreen();
                drawMe.Draw();
                SplashKit.RefreshScreen();
            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}

//Tran Quoc Dung 103803891 