namespace ClassesExercise.Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public new void Draw()
        {
            Console.WriteLine("Drawing {0}", nameof(Rectangle));
        }
    }
}
