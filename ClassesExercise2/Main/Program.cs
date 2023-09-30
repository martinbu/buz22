using Buz.Shapes;

Rectangle rect1 = new Rectangle(4, 8, 10, 20);
Rectangle rect2 = new Rectangle(6, 10, 12, 22);
Rectangle rect3 = new Rectangle(8, 12, 14, 24);

// -----------------------------------------------
// Rechteck Flächenberechnung
// -----------------------------------------------

double rect1_area = rect1.CalculateArea();
double rect2_area = rect2.CalculateArea();
double rect3_area = rect3.CalculateArea();

Console.WriteLine("Rect1 Area: {0}", rect1_area);
Console.WriteLine("Rect2 Area: {0}", rect2_area);
Console.WriteLine("Rect3 Area: {0}", rect3_area);

Console.WriteLine();

// -----------------------------------------------
// Rechteck Überschneidungsflächenberechnung
// -----------------------------------------------

Rectangle intersectionRect_r1_r2 = Rectangle.GetIntersectionRectangle(rect1, rect2);
Rectangle intersectionRect_r1_r3 = Rectangle.GetIntersectionRectangle(rect1, rect3);
Rectangle intersectionRect_r2_r3 = Rectangle.GetIntersectionRectangle(rect2, rect3);

Console.WriteLine("Intersection Rectangle (r1/r2):\n  {0},\n  Area: {1}",
    intersectionRect_r1_r2, intersectionRect_r1_r2.CalculateArea());

Console.WriteLine("Intersection Rectangle (r1/r3):\n  {0},\n  Area: {1}",
    intersectionRect_r1_r3, intersectionRect_r1_r3.CalculateArea());

Console.WriteLine("Intersection Rectangle (r2/r3):\n  {0},\n  Area: {1}",
    intersectionRect_r2_r3, intersectionRect_r2_r3.CalculateArea());

Console.WriteLine();

// -----------------------------------------------
// Statistik
// -----------------------------------------------

Console.WriteLine("Totally created rectangles: {0}", Rectangle.CreatedRectanglesCount);
