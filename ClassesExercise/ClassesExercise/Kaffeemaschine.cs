using System;

namespace ClassesExercise
{
    internal class Kaffeemaschine
    {
        //public readonly KaffeemaschinenFarbe Farbe;
        public KaffeemaschinenFarbe Farbe { get; }
        public int Stärke { get; set; }

        // Wenn static verwendet wird, dann wird diese Variable nur einmal initialisiert
        // und für alle erzeugten Instanzen geteilt.
        // Die Farbe hingegen (hat kein static keyword) wird nicht geteilt. Jedes Objekt
        // hat seine eigene Farbe
        public static int AnzahlErzeugterKaffeemaschinen { get; private set; } = 0;

        // lange schreibweise
        //private int _Stärke;
        //public int Stärke
        //{
        //    get
        //    {
        //        return _Stärke;
        //    }
        //    private set
        //    {
        //        Console.WriteLine("Setze sträke auf {0}", value);
        //        _Stärke = value;
        //    }
        //}

        public Kaffeemaschine(KaffeemaschinenFarbe farbe) : this(farbe, 5)
        {
            //Init(farbe, 5);
        }

        public Kaffeemaschine(KaffeemaschinenFarbe farbe, int stärke)
        {
            Farbe = farbe;
            Stärke = stärke;

            AnzahlErzeugterKaffeemaschinen++;
        }

        public static Kaffeemaschine CreateGreenMaschine()
        {
            return new Kaffeemaschine(KaffeemaschinenFarbe.Grün);
        }

        public static Kaffeemaschine CreateRedMaschine()
        {
            return new Kaffeemaschine(KaffeemaschinenFarbe.Rot);
        }

        //private void Init(KaffeemaschinenFarbe farbe, int stärke)
        //{
        //   // Funktioniert nicht, da die Farbe readonly ist. Kann nur noch im
        //   // Konstruktor gestzt werden.
        //    Farbe = farbe;
        //    Stärke = stärke;
        //}

        public void SetMahlgrad(int mahlgrad)
        {
            Console.WriteLine("Setze Mahlgrad auf {0}", mahlgrad);
        }

        public int GetStärke()
        {
            // this hat einen anderen Wert je nachdem auf welches
            // Objekt die Methode aufgerufen wird
            // Also z.b.
            // this = roteMaschine (wenn roteMaschine.GetStärke())
            // this = grüneMaschine (wenn grüneMaschine.GetStärke())
            // this = grüneMaschine2 (wenn grüneMaschine2.GetStärke())

            return this.Stärke;
        }

        public static int GetStärkeStatic(Kaffeemaschine thiss)
        {
            return thiss.Stärke;
        }

        public void SetStärke(int stärke)
        {
            Stärke = stärke;
            Console.WriteLine("Setze sträke auf {0}", stärke);
        }

        public void ErstelleGroßenKaffe()
        {
            StarteHeizung();

            Console.WriteLine("Mahlen, Wasserheizen und großen Menge Wasser durchlaufen lassen");
        }

        public void ErstelleKleinenKaffee()
        {
            StarteHeizung();

            Console.WriteLine("{0} Maschine: Mahlen, Wasserheizen und kleine Menge Wasser durchlaufen lassen", Farbe);
        }

        private void StarteHeizung()
        {
            Console.WriteLine("Ich starte die Heinzung");
        }
    }
}
