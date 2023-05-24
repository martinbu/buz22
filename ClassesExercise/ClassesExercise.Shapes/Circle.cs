namespace ClassesExercise.Shapes
{
    public class Circle : Shape
    {
        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0}", nameof(Circle));
        }
    }
}
