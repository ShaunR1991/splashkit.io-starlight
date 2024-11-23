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

            // Load the bitmaps
            Bitmap skBmp = LoadBitmap("skbox", "skbox.png");
            Bitmap fileBmp = LoadBitmap("file", "file_image.png");
            Bitmap bugBmp = LoadBitmap("bug", "bug_image.png");

            // Set the bitmap locations using Point2D
            Point2D skBmpLoc = new Point2D() { X = 50, Y = 50 };
            Point2D fileBmpLoc = new Point2D() { X = 20, Y = 20 };
            Point2D bugBmpLoc = new Point2D() { X = 200, Y = 150 };

            // Clear the screen and draw the bitmaps
            ClearScreen(Color.White);
            DrawBitmap(skBmp, skBmpLoc.X, skBmpLoc.Y);
            DrawBitmap(fileBmp, fileBmpLoc.X, fileBmpLoc.Y);
            DrawBitmap(bugBmp, bugBmpLoc.X, bugBmpLoc.Y);

            // Check for collisions
            if (BitmapCollision(skBmp, skBmpLoc, fileBmp, fileBmpLoc))
            {
                WriteLine("SplashKit got a new file!");
            }

            if (BitmapCollision(skBmp, skBmpLoc, bugBmp, bugBmpLoc))
            {
                WriteLine("SplashKit has bugs!");
            }

            // Refresh the screen and wait
            RefreshScreen();
            Delay(4000);

            // Close all windows
            CloseAllWindows();
        }
    }
}
