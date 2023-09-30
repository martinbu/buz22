namespace Buz.Shapes
{
    public class Rectangle
    {
        public static int CreatedRectanglesCount { get; private set; }

        public double PosX;
        public double PosY;
        public double Width;
        public double Height;

        public Rectangle(double posX, double posY, double width, double height)
        {
            PosX = posX;
            PosY = posY;
            Width = width;
            Height = height;

            CreatedRectanglesCount++;
        }


        // r.CalculateArea() --> r wird zu implizitem Übergabeparameter this. this is Optional
        public double CalculateArea(/*Rectangle this*/)
        {
            double area = this.Height * Width;
            return area;
        }

        public static double CalculateIntersectionArea(Rectangle r1, Rectangle r2)
        {
            var intersectionRect = Rectangle.GetIntersectionRectangle(r1, r2);
            var intersectionRectArea = intersectionRect.CalculateArea();

            return intersectionRectArea;
        }

        public static Rectangle GetIntersectionRectangle(Rectangle r1, Rectangle r2)
        {
            double left = Math.Max(r1.PosX, r2.PosX);
            double right = Math.Min(r1.PosX + r1.Width, r2.PosX + r2.Width);
            double bottom = Math.Max(r1.PosY, r2.PosY);
            double top = Math.Min(r1.PosY + r1.Height, r2.PosY + r2.Height);

            bool hasIntersection = left < right && bottom < top;

            if (hasIntersection == false)
            {
                return new Rectangle(0, 0, 0, 0);
            }
            else
            {
                double posX = left;
                double posY = bottom;
                double width = right - left;
                double height = top - bottom;

                return new Rectangle(posX, posY, width, height);
            }
        }

        public override string ToString()
        {
            return $"X: {PosX}, Y: {PosY}, Width: {Width}, Height: {Height}";
        }
    }
}
