using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace ZeroVectorCheckDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the first vector
            Vector2D myVector1 = new Vector2D() { X = 200, Y = 100 };

            // Define the second vector (zero vector)
            Vector2D myVector2 = new Vector2D() { X = 0, Y = 0 };

            // Check if the vectors are zero vectors
            bool checkZero1 = IsZeroVector(myVector1);
            bool checkZero2 = IsZeroVector
