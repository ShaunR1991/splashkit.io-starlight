using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace BitmapCollisionsDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            OpenWindow("Bitmap Collisions", 315, 330);

            // Load the bitmap and set its location
            Bitmap skBmp = LoadBitmap("skbox", "skbox.png");
            Point2D bmpLoc = new Point2D() { X = 50, Y = 50 };

            // Define the rectangles
            Rectangle blackRectangle = new Rectangle()
            {
                X = 20,
                Y = 20,
                Width = 20,
                Height = 20
            };

            Rectangle redRectangle = new Rectangle()
            {
                X = 150,
                Y = 200,
                Width = 20,
                Height = 20
            };

            // Clear the screen and draw the elements
            ClearScreen(Color.Rgb(67, 80, 175));
            DrawBitmap(skBmp, bmpLoc.X, bmpLoc.Y);
            FillRectangle(Color.Black, blackRectangle);
            FillRectangle(Color.Red, redRectangle);

            // Check for collisions
            if (BitmapRectangleCollision(skBmp, 50, bmpLoc, blackRectangle))
            {
                WriteLine("Black Rectangle Collision!");
            }

            if (BitmapRectangleCollision(skBmp, 50, bmpLoc, redRectangle))
            {
                WriteLine("Red Rectangle Collision!");
            }

            // Refresh the screen and wait
            RefreshScreen();
            Delay(4000);

            // Close all windows
            CloseAllWindows();
        }
    }
}