using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the window
OpenWindow("Vector Visualisations", 300, 300);

// Define outer and inner circles
Circle outerCircle = new Circle() { Center = new Point2D() { X = 150, Y = 150 }, Radius = 75 };
Circle innerCircle = new Circle() { Center = new Point2D() { X = 150, Y = 150 }, Radius = 25 };

// Define velocity vector
Vector2D velocity = new Vector2D() { X = 10, Y = 10 };

// Calculate escape vector
Vector2D escape = VectorOutOfCircleFromCircle(innerCircle, outerCircle, velocity);

// Create line representing the escape vector
Line vectorLine = LineFrom(innerCircle.Center, escape);

// Clear the screen and draw shapes
ClearScreen();
FillCircle(ColorBlack, outerCircle);
FillCircle(ColorYellow, innerCircle);

// Draw the escape vector line
DrawLine(ColorRed, vectorLine);

// Refresh the screen
RefreshScreen();

// Wait and close the window
Delay(4000);
CloseAllWindows();
