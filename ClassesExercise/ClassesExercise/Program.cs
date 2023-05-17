namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaffemaschine roteMaschine = new Kaffemaschine();
            roteMaschine.Farbe = "Rot";

            Kaffemaschine grüneMaschine = new Kaffemaschine();
            grüneMaschine.Farbe = "Grün";

            roteMaschine.ErstelleKleinenKaffee();
            grüneMaschine.ErstelleKleinenKaffee();
        }
    }
}