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

            // Load the bitmap
            Bitmap skBmp = LoadBitmap("skbox", "skbox.png");

            // Set the bitmap and dot locations using Point2D
            Point2D skBmpLoc = new Point2D() { X = 50, Y = 50 };
            Point2D blackDotLoc = new Point2D() { X = 20, Y = 20 };
            Point2D redDotLoc = new Point2D() { X = 200, Y = 150 };

            // Create a translation matrix for the bitmap
            Matrix2D skBmpMatrix = TranslationMatrix(skBmpLoc);

            // Clear the screen and draw the bitmap and dots
            ClearScreen(Color.White);
            DrawBitmap(skBmp, skBmpLoc.X, skBmpLoc.Y);
            FillCircle(Color.Black, CircleAt(blackDotLoc, 2));
            FillCircle(Color.Red, CircleAt(redDotLoc, 2));

            // Check for collisions
            if (BitmapPointCollision(skBmp, skBmpMatrix, blackDotLoc))
            {
                WriteLine("Black Dot Collision");
            }

            if (BitmapPointCollision(skBmp, skBmpMatrix, redDotLoc))
            {
                WriteLine("Red Dot Collision!");
            }

            // Refresh the screen and wait
            RefreshScreen();
            Delay(4000);

            // Close all windows
            CloseAllWindows();
        }
    }
}
