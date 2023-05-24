using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunKaffeemaschinenBeispiel();
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