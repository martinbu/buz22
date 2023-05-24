namespace ClassesExercise.Shapes
{

    public interface Shape
    {
        Position Position { get; set; }
        double CalculateArea();
        void Draw();
    }

    //public abstract class Shape
    //{
    //    public Position Position { get; set; }

    //    public Shape(double x, double y)
    //    {
    //        Position = new Position(x, y);
    //    }

    //    public abstract double CalculateArea();
    //    public abstract void Draw();
    //}

    public class Triangle : Shape
    {
        public Position Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

}