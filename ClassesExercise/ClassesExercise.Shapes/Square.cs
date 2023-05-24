namespace ClassesExercise.Shapes
{
    public class Square : Rectangle
    {
        public Square(double x, double y, double width)
            : base(x, y, width, width)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0}", nameof(Square));
        }
    }
}
