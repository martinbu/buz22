using ClassesExercise.Shapes;
using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunShapesExample();
            //RunKaffeemaschinenBeispiel();
        }

        static void RunShapesExample()
        {
            Shape shape = new Shape(0, 0);
            Rectangle rectangle = new Rectangle(0, 0, 20, 50);
            Square square = new Square(0, 0, 50);
            Circle circle = new Circle(0, 0, 20);

            Console.WriteLine("---------- {0} -----------", typeof(Shape));
            shape.Draw();
            Console.WriteLine("Shape Area: {0}", shape.CalculateArea());

            Console.WriteLine();
            Console.WriteLine("---------- {0} -----------", typeof(Rectangle));
            rectangle.Draw();
            Console.WriteLine("Rectangle Area: {0}", rectangle.CalculateArea());

            Console.WriteLine();
            Console.WriteLine("---------- {0} -----------", typeof(Square));
            square.Draw();
            Console.WriteLine("Square Area: {0}", square.CalculateArea());

            Console.WriteLine();
            Console.WriteLine("---------- {0} -----------", typeof(Circle));
            circle.Draw();
            Console.WriteLine("Circle Area: {0}", circle.CalculateArea());
        }

        static void RunKaffeemaschinenBeispiel()
        {
            Kaffeemaschine roteMaschine = new Kaffeemaschine(KaffeemaschinenFarbe.Rot);

            // funktioniert nicht, da Farbe readonly ist
            // roteMaschine.Farbe = KaffeemaschinenFarbe.Grün;

            Console.WriteLine("Maschinen erzeugt: {0}", Kaffeemaschine.AnzahlErzeugterKaffeemaschinen);

            Kaffeemaschine grüneMaschine = new Kaffeemaschine(KaffeemaschinenFarbe.Grün);

            Console.WriteLine("Maschinen erzeugt: {0}", Kaffeemaschine.AnzahlErzeugterKaffeemaschinen);

            Kaffeemaschine grüneMaschine2 = new Kaffeemaschine(KaffeemaschinenFarbe.Grün);

            Console.WriteLine("Maschinen erzeugt: {0}", Kaffeemaschine.AnzahlErzeugterKaffeemaschinen);

            grüneMaschine.Stärke = 5;
            var stärke = grüneMaschine.Stärke;

            Console.WriteLine("Stärke der grünen Maschine ist {0}", stärke);

            roteMaschine.ErstelleKleinenKaffee();
            grüneMaschine.ErstelleKleinenKaffee();


            grüneMaschine.GetStärke();
            Kaffeemaschine.GetStärkeStatic(grüneMaschine);
        }
    }
}